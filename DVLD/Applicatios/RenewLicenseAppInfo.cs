using DVLD.International;
using DVLD.Licenses;
using DVLDBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applicatios
{
    public partial class RenewLicenseAppInfo : Form
    {
        private int _SelectedLicenseID = -1;
        private clsLicense _OldLicense = null;
        private clsLicense _NewLicense = null;
        private int _NewLicenseID = -1;
        private const int RENEW_APPLICATION_TYPE_ID = 2;

        public RenewLicenseAppInfo()
        {
            InitializeComponent();

            // Initialize default values safely on form load
            ResetDefaultValues();

            // Subscribe to event from filter control
            uscLicenseCardWithFilter1.DataBack += LicenseInfo_DataBack;
        }

        private void ResetDefaultValues()
        {
            latxtAppDate.Text = DateTime.Now.ToShortDateString();
            latxtIssueDate.Text = DateTime.Now.ToShortDateString();

            // Load Application Type Fees
            clsApplicationTypes appType = clsApplicationTypes.GetApplicationTypesInfoByID(RENEW_APPLICATION_TYPE_ID);
            decimal appFees = (appType != null) ? appType.ApplicationFees : 0;
            latxtAppFees.Text = appFees.ToString("0.00");

            if (Golbal.GolbalUser.CurrentUser != null)
                latxtUser.Text = Golbal.GolbalUser.CurrentUser.UserName;

            // Disable buttons and links initially
            bIssue.Enabled = false;
            linkLabelInfo.Enabled = false;
            linkLabelHistory.Enabled = false;
        }

        private void LicenseInfo_DataBack(object sender, int licenseID)
        {
            _SelectedLicenseID = licenseID;
            _OldLicense = clsLicense.Find(licenseID);
           
          if (_OldLicense == null)
            {
                MessageBox.Show("Selected license was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bIssue.Enabled = false;
                linkLabelHistory.Enabled = false;
                return;
            }

            linkLabelHistory.Enabled = true;

            uscLicenseCardWithFilter1.clsLicenseCard1.FillAllTextBoxes(licenseID);

            latxtLocalID.Text = _SelectedLicenseID.ToString();
            latxtLicFees.Text = _OldLicense.PaidFees.ToString("0.00");

            decimal appFees = Convert.ToDecimal(latxtAppFees.Text);
            decimal licFees = _OldLicense.PaidFees;
            latxtTotFees.Text = (appFees + licFees).ToString("0.00");

            if (clsLicense.IsLicenseExpired(licenseID))
            {
                bIssue.Enabled = true;
                int validityYears = (_OldLicense.LicenseClassInfo != null) ? (int)_OldLicense.LicenseClassInfo.DefaultValidityLength : 10;
                latxtEenDate.Text = DateTime.Now.AddYears(validityYears).ToShortDateString();
            }
            else
            {
                MessageBox.Show($"Selected License is not yet expired, It expires on: {_OldLicense.ExpirationDate.ToShortDateString()}",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                bIssue.Enabled = false;
            }
        }

        private void bIssue_Click(object sender, EventArgs e)
        {
            
            if (_OldLicense == null || _SelectedLicenseID == -1)
            {
                MessageBox.Show("Please select a driver license first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!clsLicense.IsLicenseExpired(_SelectedLicenseID))
            {
                MessageBox.Show("Cannot renew a license that is not expired!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsApplication application = new clsApplication();

            var person = clsPeople.GetClsPeopleByNationalNO(uscLicenseCardWithFilter1.clsLicenseCard1.latxtNationalNo.Text);
            if (person == null)
            {
                MessageBox.Show("Could not find the person owning this license!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            application.ApplicantPersonID = person.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationTypeID = RENEW_APPLICATION_TYPE_ID;
            application.ApplicationStatus = 3; // Completed
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = Convert.ToDecimal(latxtAppFees.Text);
            application.CreatedByUserID = Golbal.GolbalUser.CurrentUser.UserID;

            if (!application.Save())
            {
                MessageBox.Show("Failed to save application data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Create and Save Renewed License
            _NewLicense = new clsLicense();
            _NewLicense.ApplicationID = application.ApplicationID;
            _NewLicense.DriverID = _OldLicense.DriverID;
            _NewLicense.LicenseClassID = _OldLicense.LicenseClassID;
            _NewLicense.IssueDate = DateTime.Now;

            int defaultValidity = (_OldLicense.LicenseClassInfo != null) ? (int)_OldLicense.LicenseClassInfo.DefaultValidityLength : 10;
            _NewLicense.ExpirationDate = DateTime.Now.AddYears(defaultValidity);

            _NewLicense.Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? "" : txtNotes.Text.Trim();
            _NewLicense.PaidFees = Convert.ToDecimal(latxtTotFees.Text);
            _NewLicense.IsActive = true;
            _NewLicense.IssueReason = clsLicense.enIssueReason.Renew;
            _NewLicense.CreatedByUserID = Golbal.GolbalUser.CurrentUser.UserID;

            if (_NewLicense.Save())
            {
                // Deactivate Old License
                _OldLicense.CancelActivity();

                _NewLicenseID = _NewLicense.LicenseID;
                latxtLicenseID.Text = _NewLicense.LicenseID.ToString();
                latxtApp.Text = application.ApplicationID.ToString();

                MessageBox.Show($"Licensed Renewed Successfully with ID = {_NewLicense.LicenseID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Disable issue button & filter to prevent duplicated saves, enable license info link
                bIssue.Enabled = false;
                uscLicenseCardWithFilter1.gbFilter.Enabled = false;
                linkLabelInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to save renewed license data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           clsPeople person = clsPeople.GetClsPeopleByNationalNO(uscLicenseCardWithFilter1.clsLicenseCard1.latxtNationalNo.Text);
            if (person == null) return;

            LicensesForm frm = new LicensesForm(person.PersonID);
            frm.ShowDialog();
        }

        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_NewLicenseID == -1) return;

            LicenseInfo frm = new LicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}