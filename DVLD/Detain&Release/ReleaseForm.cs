using System;
using System.Windows.Forms;
using DVLD.Licenses;
using DVLDBuisnessLayer;
using DVLDBusinessLayer;
using Golbal;

namespace DVLD.Detain_Release
{
    public partial class ReleaseForm : Form
    {
        private int _selectedLicenseID = -1;
        private clsLicense _oldLicense = null;
        private clsDetainedLicense _detainLicense = null;
        private const int RELEASE_APPLICATION_TYPE_ID = 5;

        public ReleaseForm()
        {
            InitializeComponent();
            ResetDefaultValues();
            uscLicenseCardWithFilter1.OnLicenseSelected += LicenseCardWithFilter_OnLicenseSelected;
        }

        public ReleaseForm(int licenseID)
        {
            InitializeComponent();
            ResetDefaultValues();
            uscLicenseCardWithFilter1.OnLicenseSelected += LicenseCardWithFilter_OnLicenseSelected;

            // تحميل البيانات مباشرة عند فتح الشاشة برقم رخصة محدد
        }  

        private void ResetDefaultValues()
        {
            if (GolbalUser.CurrentUser != null)
                latxtUser.Text = GolbalUser.CurrentUser.UserName;

            clsApplicationTypes appType = clsApplicationTypes.GetApplicationTypesInfoByID(RELEASE_APPLICATION_TYPE_ID);
            latxtAppFees.Text = (appType?.ApplicationFees ?? 0).ToString("0.00");
            bRelase.Enabled = false;
            linkLabelInfo.Enabled = false;
            linkLabelHistory.Enabled = false;
        }

        private void LicenseCardWithFilter_OnLicenseSelected(int licenseID)
        {
            _selectedLicenseID = licenseID;
            _oldLicense = clsLicense.Find(licenseID);
            _detainLicense = clsDetainedLicense.FindByLicenseID(licenseID);

            if (_oldLicense == null)
            {
                MessageBox.Show("Selected license was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bRelase.Enabled = false;
                linkLabelHistory.Enabled = false;
                return;
            }

            if (!_oldLicense.IsDetained || _detainLicense == null)
            {
                MessageBox.Show("This license is not Detained!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bRelase.Enabled = false;
                return;
            }

            latxtDetainID.Text = _detainLicense.DetainID.ToString();
            latxtDetainDate.Text = _detainLicense.DetainDate.ToShortDateString();
            latxtFineFees.Text = _detainLicense.FineFees.ToString("0.00");

            decimal appFees = decimal.TryParse(latxtAppFees.Text, out decimal fees) ? fees : 0;
            latxtTotFees.Text = (appFees + _detainLicense.FineFees).ToString("0.00");

            linkLabelHistory.Enabled = true;
            bRelase.Enabled = true;
            latxtLicenseID.Text = _selectedLicenseID.ToString();
        }

        private void bRelease_Click(object sender, EventArgs e)
        {
            if (_oldLicense == null || _detainLicense == null) return;

            clsDrivers driver = clsDrivers.Find(_oldLicense.DriverID);
            if (driver == null)
            {
                MessageBox.Show("Driver details not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsApplication application = new clsApplication
            {
                ApplicantPersonID = driver.PersonID,
                ApplicationDate = DateTime.Now,
                CreatedByUserID = GolbalUser.CurrentUser.UserID,
                ApplicationStatus = 1,
                ApplicationTypeID = RELEASE_APPLICATION_TYPE_ID,
                LastStatusDate = DateTime.Now,
                PaidFees = decimal.TryParse(latxtTotFees.Text, out decimal totFees) ? totFees : 0
            };
            if (!application.Save())
            {
                MessageBox.Show("Failed to save application data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _detainLicense.IsReleased = true;
            _detainLicense.ReleaseDate = DateTime.Now;
            _detainLicense.ReleaseApplicationID = application.ApplicationID;

            if (_detainLicense.ReleaseDetainedLicense(GolbalUser.CurrentUser.UserID, application.ApplicationID))
            {
                MessageBox.Show($"License Released Successfully with Application ID = {application.ApplicationID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                latxtApp.Text = application.ApplicationID.ToString();
                bRelase.Enabled = false;
                linkLabelInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to release detained license!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LicenseInfo frm = new LicenseInfo(_selectedLicenseID);
            frm.ShowDialog();
        }

        private void bClose_Click(object sender, EventArgs e) => this.Close();
    }
}