using System;
using System.Windows.Forms;
using DVLD.Licenses;
using DVLDBuisnessLayer;
using DVLDBusinessLayer;
using Golbal;

namespace DVLD.Detain_Release
{
    public partial class DetainForm : Form
    {
        private int _selectedLicenseID = -1;
        private clsLicense _oldLicense = null;
        private clsDetainedLicense _detainLicense = null;

        public DetainForm()
        {
            InitializeComponent();
            ResetDefaultValues();

            // الاشتراك بحدث اختيار الرخصة من الفلتر
            uscLicenseCardWithFilter1.OnLicenseSelected += LicenseCardWithFilter_OnLicenseSelected;
        }

        private void ResetDefaultValues()
        {
            latxtDetainDate.Text = DateTime.Now.ToShortDateString();
            if (GolbalUser.CurrentUser != null)
                latxtUser.Text = GolbalUser.CurrentUser.UserName;

            bDetain.Enabled = false;
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
                bDetain.Enabled = false;
                linkLabelHistory.Enabled = false;
                return;
            }

            if (!_oldLicense.IsActive)
            {
                MessageBox.Show("This license is not Active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bDetain.Enabled = false;
                return;
            }

            if (_oldLicense.IsDetained)
            {
                MessageBox.Show("This license is already Detained!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bDetain.Enabled = false;
                return;
            }

            bDetain.Enabled = true;
            linkLabelHistory.Enabled = true;
            latxtLicenseID.Text = _selectedLicenseID.ToString();
        }

        private void bDetain_Click(object sender, EventArgs e)
        {
            if (_oldLicense == null || !_oldLicense.IsActive) return;

            _detainLicense = new clsDetainedLicense
            {
                LicenseID = _oldLicense.LicenseID,
                DetainDate = DateTime.Now,
                FineFees = decimal.TryParse(txtFineFees.Text, out decimal fees) ? fees : 0,
                CreatedByUserID = GolbalUser.CurrentUser.UserID,
                IsReleased = false
            };

            if (_detainLicense.Save())
            {
                MessageBox.Show($"License Detained Successfully with ID = {_detainLicense.DetainID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                latxtDetainID.Text = _detainLicense.DetainID.ToString();
                bDetain.Enabled = false;
                linkLabelInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to detain license data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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