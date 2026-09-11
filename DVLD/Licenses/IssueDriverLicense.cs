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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Tests
{
    public partial class IssueDriverLicense : Form
    {
        int _ID;
        clsLocalDrivingLicenseApplication _Application = new clsLocalDrivingLicenseApplication();
        clsLicense _License = new clsLicense();
        public IssueDriverLicense(int iD)
        {
            InitializeComponent();
            _ID = iD;
            ldlAppilcationCard1.RefreshInfo(_ID);
            _Application = clsLocalDrivingLicenseApplication.FindByID(_ID);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private clsLicense CreateLicense()
        {
            clsDrivers Driver = clsDrivers.FindByPersonID(_Application.ApplicantPersonID);


            if (Driver == null)
            {
                Driver = new clsDrivers();
                Driver.PersonID = _Application.ApplicantPersonID;
                Driver.CreatedByUserID = _Application.CreatedByUserID;
                Driver.CreatedDate = DateTime.Now;

                if (!Driver.Save())
                {
                    MessageBox.Show("Failed to add new driver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            // 3. إنشاء الرخصة باستخدام DriverID الأصلي أو الجديد
            clsLicense License = new clsLicense();
            License.DriverID = Driver.DriverID;
            License.CreatedByUserID = _Application.CreatedByUserID;
            License.IssueDate = DateTime.Now;
            License.PaidFees = Convert.ToDecimal(ldlAppilcationCard1.latxtFees.Text);
            License.LicenseClassID = Convert.ToInt32(_Application.LicenseClassID);
            int validityYears = Convert.ToInt32(clsLicenseClass.Find(License.LicenseClassID).DefaultValidityLength);
            License.ExpirationDate = License.IssueDate.AddYears(validityYears);
            License.Notes = string.IsNullOrEmpty(txtNotes.Text) ? null : txtNotes.Text;
            License.IssueReason = clsLicense.enIssueReason.FirstTime;
            License.ApplicationID = _Application.ApplicationID;
            License.IsActive = true;

            return License;
        }
        private void bIssue_Click(object sender, EventArgs e)
        {
            _License = CreateLicense();

            if (_License == null)
                return;

            if (_License.Save())
            {
                MessageBox.Show("License Issued Successfully with License ID = " + _License.LicenseID, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_Application.Complete())
                {
                    MessageBox.Show("Done");
                }
            }
            else
            {
                MessageBox.Show("Failed to Issue License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
