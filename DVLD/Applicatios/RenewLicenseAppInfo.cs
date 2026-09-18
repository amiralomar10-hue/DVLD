using System;
using System.Windows.Forms;
using DVLD.Licenses;
using DVLDBusinessLayer;
using Golbal;

namespace DVLD.Applicatios
{
    public partial class RenewLicenseAppInfo : Form
    {
        private int _selectedLicenseID = -1;
        private clsLicense _oldLicense = null;
        private clsLicense _newLicense = null;
        private int _newLicenseID = -1;
        private const int RENEW_APPLICATION_TYPE_ID = 2;

        public RenewLicenseAppInfo()
        {
            InitializeComponent();
            ResetDefaultValues();

            // الاشتراك بحدث اختيار الرخصة من الفلتر
            uscLicenseCardWithFilter1.OnLicenseSelected += LicenseCardWithFilter_OnLicenseSelected;
        }

        private void ResetDefaultValues()
        {
            latxtAppDate.Text = DateTime.Now.ToShortDateString();
            latxtIssueDate.Text = DateTime.Now.ToShortDateString();

            clsApplicationTypes appType = clsApplicationTypes.GetApplicationTypesInfoByID(RENEW_APPLICATION_TYPE_ID);
            latxtAppFees.Text = (appType?.ApplicationFees ?? 0).ToString("0.00");

            if (GolbalUser.CurrentUser != null)
                latxtUser.Text = GolbalUser.CurrentUser.UserName;

            bIssue.Enabled = false;
            linkLabelInfo.Enabled = false;
            linkLabelHistory.Enabled = false;
        }

        private void LicenseCardWithFilter_OnLicenseSelected(int licenseID)
        {
            _selectedLicenseID = licenseID;
            _oldLicense = clsLicense.Find(licenseID);

            if (_oldLicense == null)
            {
                MessageBox.Show("Selected license was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bIssue.Enabled = false;
                linkLabelHistory.Enabled = false;
                return;
            }

            linkLabelHistory.Enabled = true;
            latxtLocalID.Text = _selectedLicenseID.ToString();
            latxtLicFees.Text = _oldLicense.PaidFees.ToString("0.00");

            decimal appFees = decimal.TryParse(latxtAppFees.Text, out decimal fees) ? fees : 0;
            latxtTotFees.Text = (appFees + _oldLicense.PaidFees).ToString("0.00");

            if (clsLicense.IsLicenseExpired(licenseID))
            {
                bIssue.Enabled = true;
                int validityYears = _oldLicense.LicenseClassInfo?.DefaultValidityLength ?? 10;
                latxtEenDate.Text = DateTime.Now.AddYears(validityYears).ToShortDateString();
            }
            else
            {
                MessageBox.Show($"Selected License is not yet expired. It expires on: {_oldLicense.ExpirationDate.ToShortDateString()}",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                bIssue.Enabled = false;
            }
        }

        private void bIssue_Click(object sender, EventArgs e)
        {
            if (_oldLicense == null || _selectedLicenseID == -1)
            {
                MessageBox.Show("Please select a driver license first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clsLicense.IsLicenseExpired(_selectedLicenseID))
            {
                MessageBox.Show("Cannot renew a license that is not expired!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsDrivers driver = clsDrivers.Find(_oldLicense.DriverID);
            if (driver == null)
            {
                MessageBox.Show("Could not find the driver owning this license!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsApplication application = new clsApplication
            {
                ApplicantPersonID = driver.PersonID,
                ApplicationDate = DateTime.Now,
                ApplicationTypeID = RENEW_APPLICATION_TYPE_ID,
                ApplicationStatus = 3, // Completed
                LastStatusDate = DateTime.Now,
                PaidFees = decimal.TryParse(latxtAppFees.Text, out decimal fees) ? fees : 0,
                CreatedByUserID = GolbalUser.CurrentUser.UserID
            };

            if (!application.Save())
            {
                MessageBox.Show("Failed to save application data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int defaultValidity = _oldLicense.LicenseClassInfo?.DefaultValidityLength ?? 10;
            _newLicense = new clsLicense
            {
                ApplicationID = application.ApplicationID,
                DriverID = _oldLicense.DriverID,
                LicenseClassID = _oldLicense.LicenseClassID,
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(defaultValidity),
                Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? string.Empty : txtNotes.Text.Trim(),
                PaidFees = decimal.TryParse(latxtTotFees.Text, out decimal totFees) ? totFees : 0,
                IsActive = true,
                IssueReason = clsLicense.enIssueReason.Renew,
                CreatedByUserID = GolbalUser.CurrentUser.UserID
            };

            if (_newLicense.Save())
            {
                _oldLicense.CancelActivity();
                _newLicenseID = _newLicense.LicenseID;
                latxtLicenseID.Text = _newLicense.LicenseID.ToString();
                latxtApp.Text = application.ApplicationID.ToString();

                MessageBox.Show($"License Renewed Successfully with ID = {_newLicense.LicenseID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bIssue.Enabled = false;
                linkLabelInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to save renewed license data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_oldLicense == null) return;
            clsDrivers driver = clsDrivers.Find(_oldLicense.DriverID);
            if (driver == null) return;

            LicensesForm frm = new LicensesForm(driver.PersonID);
            frm.ShowDialog();
        }

        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_newLicenseID == -1) return;
            LicenseInfo frm = new LicenseInfo(_newLicenseID);
            frm.ShowDialog();
        }

        private void bClose_Click(object sender, EventArgs e) => this.Close();
    }
}