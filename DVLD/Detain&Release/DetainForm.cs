using DVLD.Licenses;
using DVLDBuisnessLayer;
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

namespace DVLD.Detain_Release
{
    public partial class DetainForm : Form
    {
        int _SelectedLicenseID = 0;
        clsLicense _OldLicense = null;
       clsDetainedLicense _DetainLicense = null;
        public DetainForm()
        {
            InitializeComponent();
            ResetDefaultValues();
            uscLicenseCardWithFilter1.DataBack += LicenseInfo_DataBack;
        }

        private void ResetDefaultValues()
        {
            latxtDetainDate.Text = DateTime.Now.ToString();

            if (Golbal.GolbalUser.CurrentUser != null)
                latxtUser.Text = Golbal.GolbalUser.CurrentUser.UserName;

        }

        private void LicenseInfo_DataBack(object sender, int licenseID)
        {
            _SelectedLicenseID = licenseID;
            _OldLicense = clsLicense.Find(licenseID);

            if (_OldLicense == null)
            {
                MessageBox.Show("Selected license was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bDetain.Enabled = false;
                linkLabelHistory.Enabled = false;
                return;
            }
            if (_OldLicense.IsActive == false)
            {
                MessageBox.Show("This license is not Active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bDetain.Enabled = false;
            }

            linkLabelHistory.Enabled = true;

            uscLicenseCardWithFilter1.clsLicenseCard1.FillAllTextBoxes(licenseID);

            latxtLicenseID.Text = _SelectedLicenseID.ToString();

            
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

            LicenseInfo frm = new LicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public clsDetainedLicense FillLicenseInfo()
        {
            clsDetainedLicense license = new clsDetainedLicense();

            
            license.FineFees = (String.IsNullOrEmpty(txtFineFees.Text)) ? 0 : Decimal.Parse(txtFineFees.Text);
             license.CreatedByUserID = Golbal.GolbalUser.CurrentUser.UserID;
            license.DetainDate = DateTime.Now;
            license.LicenseID = _OldLicense.LicenseID;
            license.IsReleased = false;
            return license;
        }

        private void bDetain_Click(object sender, EventArgs e)
        {
            _DetainLicense = FillLicenseInfo();

            if (_DetainLicense.Save())
            {
                MessageBox.Show($"Licensed Renewed Successfully with ID = {_DetainLicense.DetainID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  _OldLicense.
              latxtDetainID.Text = _DetainLicense.DetainID.ToString();
                bDetain.Enabled = false;
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
