using System;
using System.Windows.Forms;
using DVLD.International;
using DVLD.Licenses;
using DVLDBusinessLayer;
using Golbal;

namespace DVLD
{
    public partial class InternationalInfo : Form
    {
        private const int INTERNATIONAL_APP_TYPE_ID = 6;
        private int _selectedLocalLicenseID = -1;
        private clsInternationalLicenses _internationalLicense = new clsInternationalLicenses();
        private clsApplication _application = new clsApplication();

        public InternationalInfo()
        {
            InitializeComponent();

            // الاشتراك بحدث اختيار الرخصة من الفلتر
            uscLicenseCardWithFilter1.OnLicenseSelected += LicenseCardWithFilter_OnLicenseSelected;
            FillDefaultInfo();
        }

        private void FillDefaultInfo()
        {
            latxtAppDate.Text = DateTime.Now.ToShortDateString();
            latxtEenDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            latxtIssueDate.Text = DateTime.Now.ToShortDateString();

            clsApplicationTypes appType = clsApplicationTypes.GetApplicationTypesInfoByID(INTERNATIONAL_APP_TYPE_ID);
            latxtFees.Text = (appType?.ApplicationFees ?? 0).ToString("0.00");
            latxtUser.Text = GolbalUser.CurrentUser?.UserID.ToString() ?? "N/A";
            bIssue.Enabled = false;
            linkLabelInfo.Enabled = false;
        }

        private void LicenseCardWithFilter_OnLicenseSelected(int licenseID)
        {
            _selectedLocalLicenseID = licenseID;
            clsLicense localLicense = clsLicense.Find(licenseID);

            if (localLicense == null)
            {
                MessageBox.Show("License does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                bIssue.Enabled = false;
                return;
            }

            latxtLocalID.Text = licenseID.ToString();
            bIssue.Enabled = true;
        }

        private void bIssue_Click(object sender, EventArgs e)
        {
            if (_selectedLocalLicenseID == -1)
            {
                MessageBox.Show("Please select a local license first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLicense localLicense = clsLicense.Find(_selectedLocalLicenseID);

            if (localLicense == null)
            {
                MessageBox.Show("Invalid Local License selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (localLicense.LicenseClassID != 3) // Class 3 = Ordinary Driving License
            {
                MessageBox.Show("International license can only be issued for Class 3 Local Licenses!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsInternationalLicenses.IsExit(_selectedLocalLicenseID))
            {
                var existingApp = clsInternationalLicenses.FindByLocalID(_selectedLocalLicenseID);
                MessageBox.Show($"Person already holds an active International License with ID = [{existingApp?.InternationalLicenseID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsDrivers driver = clsDrivers.Find(localLicense.DriverID);
            if (driver == null)
            {
                MessageBox.Show("Driver not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _application.ApplicantPersonID = driver.PersonID;
            _application.ApplicationDate = DateTime.Now;
            _application.ApplicationTypeID = INTERNATIONAL_APP_TYPE_ID;
            _application.ApplicationStatus = 1;
            _application.LastStatusDate = DateTime.Now;
            _application.CreatedByUserID = GolbalUser.CurrentUser.UserID;
            _application.PaidFees = clsApplicationTypes.GetApplicationTypesInfoByID(INTERNATIONAL_APP_TYPE_ID)?.ApplicationFees ?? 0;
            if (!_application.Save())
            {
                MessageBox.Show("Failed to save Application details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _internationalLicense.ApplicationID = _application.ApplicationID;
            _internationalLicense.DriverID = localLicense.DriverID;
            _internationalLicense.IssuedUsingLocalLicenseID = _selectedLocalLicenseID;
            _internationalLicense.IssueDate = DateTime.Now;
            _internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            _internationalLicense.IsActive = true;
            _internationalLicense.CreatedByUserID = GolbalUser.CurrentUser.UserID;

            if (_internationalLicense.Save())
            {
                MessageBox.Show("International License Issued Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                latxtLicenseID.Text = _internationalLicense.InternationalLicenseID.ToString();
                latxtApp.Text = _application.ApplicationID.ToString();
                linkLabelInfo.Enabled = true;
                bIssue.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to save International License details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_selectedLocalLicenseID == -1) return;
            clsLicense localLicense = clsLicense.Find(_selectedLocalLicenseID);
            if (localLicense == null) return;

            clsDrivers driver = clsDrivers.Find(localLicense.DriverID);
            if (driver == null) return;

            LicensesForm frm = new LicensesForm(driver.PersonID);
            frm.ShowDialog();
        }

        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowInternationalLicense frm = new ShowInternationalLicense(_internationalLicense.InternationalLicenseID);
            frm.ShowDialog();
        }

        private void bClose_Click(object sender, EventArgs e) => this.Close();
    }
}