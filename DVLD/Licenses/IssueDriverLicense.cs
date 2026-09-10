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
            clsLicense License = new clsLicense();
            clsDrivers Driver = new clsDrivers();
            Driver.PersonID = _Application.ApplicantPersonID;
            Driver.CreatedByUserID =_Application.CreatedByUserID;
            Driver.CreatedDate = DateTime.Now;      

            if (Driver.Save())
            {
                License.DriverID = Driver.DriverID;
                License.CreatedByUserID = Driver.CreatedByUserID;
                License.IssueDate = Driver.CreatedDate;
                License.PaidFees = Convert.ToDecimal(ldlAppilcationCard1.latxtFees.Text);
                License.LicenseClassID = Convert.ToInt32(_Application.LicenseClassID);       
                int Date = Convert.ToInt32(clsLicenseClass.Find(License.LicenseClassID).DefaultValidityLength);
                License.ExpirationDate = License.IssueDate.AddYears(Date);
                License.Notes = (String.IsNullOrEmpty(txtNotes.Text)) ? null : txtNotes.Text;
                License.IssueReason = clsLicense.enIssueReason.FirstTime;
                License.ApplicationID = _Application.ApplicationID;
                License.IsActive = true;
                
             }
            return License;
        }
        private void bIssue_Click(object sender, EventArgs e)
        {
            _License = CreateLicense();
            if (_License.Save())
            {
                MessageBox.Show("License Issued Successfully with License ID = " + _License.LicenseID,"Succeded",MessageBoxButtons.OK , MessageBoxIcon.Information);
                if (_Application.Complete())
                {
                    MessageBox.Show("Done");
                }
            }
            else
            {
                MessageBox.Show("Stop", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
