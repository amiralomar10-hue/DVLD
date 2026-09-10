using DVLD.Licenses;
using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class ReplacementforDamagedorLostLicenses : Form
    {
        private const int Damaged_License_APPLICATION_TYPE_ID = 4;
        private const int Lost_License_APPLICATION_TYPE_ID = 3;
       clsApplicationTypes  Type = new clsApplicationTypes();
        clsLicense _OldLicense = new clsLicense();
        clsLicense _NewLicense = new clsLicense();
        private int _NewLicenseID = -1;

        int ID;
        public ReplacementforDamagedorLostLicenses()
        {
            InitializeComponent();
            ResetDefaultValues();

            uscLicenseCardWithFilter1.DataBack += LicenseInfo_DataBack;
        }
        private void ResetDefaultValues()
        {
            latxtAppDate.Text = DateTime.Now.ToShortDateString();

            // Load Application Type Fees
            decimal appFees = (Type != null) ? Type.ApplicationFees : 0;
            latxtAppFees.Text = appFees.ToString("0.00");

            if (Golbal.GolbalUser.CurrentUser != null)
                latxtUser.Text = Golbal.GolbalUser.CurrentUser.UserName;
            decimal Fees = 5;
            latxtAppFees.Text = Fees.ToString();
            laTitle.Text = "Replacement for a Damaged Driving License";
            // Disable buttons and links initially
            bIssue.Enabled = false;
            linkLabelInfo.Enabled = false;
            linkLabelHistory.Enabled = false;

             int id =  (rbDamaged.Checked) ? Damaged_License_APPLICATION_TYPE_ID : Lost_License_APPLICATION_TYPE_ID;
            Type = clsApplicationTypes.GetApplicationTypesInfoByID(id);
        }

        private void LicenseInfo_DataBack(object sender, int licenseID)
        {
            ID = licenseID;
            _OldLicense = clsLicense.Find(licenseID);
            if (_OldLicense.IsActive == false)
            {
                MessageBox.Show("This license is not Active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bIssue.Enabled = false;
            }
            else if (_OldLicense == null)
            {
                MessageBox.Show("Selected license was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bIssue.Enabled = false;
                linkLabelHistory.Enabled = false;
                return;
            }
            else
            {
                bIssue.Enabled = true;
            }

            linkLabelHistory.Enabled = true;

            uscLicenseCardWithFilter1.clsLicenseCard1.FillAllTextBoxes(licenseID);

            latxtLocalID.Text = ID.ToString();

        }


        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            Type = clsApplicationTypes.GetApplicationTypesInfoByID(Damaged_License_APPLICATION_TYPE_ID);
            laTitle.Text = Type.ApplicationTypeTitle;
            latxtAppFees.Text = Type.ApplicationFees.ToString();
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            Type = clsApplicationTypes.GetApplicationTypesInfoByID(Lost_License_APPLICATION_TYPE_ID);
            laTitle.Text = Type.ApplicationTypeTitle;
            latxtAppFees.Text = Type.ApplicationFees.ToString();
        }

        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var person = clsPeople.GetClsPeopleByNationalNO(uscLicenseCardWithFilter1.clsLicenseCard1.latxtNationalNo.Text);
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

        private void bIssue_Click(object sender, EventArgs e)
        {
            if (_OldLicense == null || ID == -1)
            {
                MessageBox.Show("Please select a driver license first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            application.ApplicationTypeID = Type.ApplicationTypeID;
            application.ApplicationStatus = 3; // Completed
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = Type.ApplicationFees;
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

            _NewLicense.Notes = "" ;
            _NewLicense.PaidFees = Convert.ToDecimal(latxtAppFees.Text);
            _NewLicense.IsActive = true;
            _NewLicense.IssueReason = (rbDamaged.Checked) ? clsLicense.enIssueReason.ReplacementForDamaged : clsLicense.enIssueReason.ReplacementForLost;
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
    }
    
}
