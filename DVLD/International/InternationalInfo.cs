using DVLDBusinessLayer;
using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using DVLD.Licenses;
using DVLD.International;

namespace DVLD
{
    public partial class InternationalInfo : Form
    {
        clsInternationalLicenses _license = new clsInternationalLicenses();
        clsApplication application = new clsApplication();
        public InternationalInfo()
        {
            InitializeComponent();
            uscLicenseCardWithFilter1.DataBack += LicenseInfo;
            FillInfo();
        }
        void LicenseInfo(object sender , int ID)
        {
            if (clsLicense.IsExsit(ID))
            {
                uscLicenseCardWithFilter1.clsLicenseCard1.FillAllTextBoxes(ID);
                uscLicenseCardWithFilter1.gbFilter.Enabled = false;
            }
            else
            {
                MessageBox.Show("There is no License ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void label17_Click(object sender, EventArgs e)
        {
        }
        private void FillInfo()
        { 
         latxtAppDate.Text = DateTime.Now.ToShortDateString();
        latxtEenDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            latxtFees.Text = clsApplicationTypes.GetApplicationTypesInfoByID(6).ApplicationFees.ToString();
            latxtIssueDate.Text = DateTime.Now.ToShortDateString();
            latxtLocalID.Text = uscLicenseCardWithFilter1.clsLicenseCard1.latxtLicenseID.Text;
            latxtUser.Text = Golbal.GolbalUser.CurrentUser.UserID.ToString();
        }
        private void InternationalInfo_Load(object sender, EventArgs e)
        {

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bIssue_Click(object sender, EventArgs e)
        {
            _license.IssueDate = (DateTime.TryParse(latxtIssueDate.Text, out DateTime date)) ? date : DateTime.Now;
            _license.ExpirationDate = (DateTime.TryParse(latxtEenDate.Text, out DateTime date2)) ? date2 : DateTime.Now;
            _license.IssuedUsingLocalLicenseID = Convert.ToInt32(uscLicenseCardWithFilter1.clsLicenseCard1.latxtLicenseID.Text);
            _license.CreatedByUserID = Golbal.GolbalUser.CurrentUser.UserID;
            _license.DriverID = clsLicense.Find(Convert.ToInt32(uscLicenseCardWithFilter1.clsLicenseCard1.latxtLicenseID.Text)).DriverID;
            _license.IsActive = (clsLicense.Find(Convert.ToInt32(uscLicenseCardWithFilter1.clsLicenseCard1.latxtLicenseID.Text)).IsActive) ? true : false;

            application.ApplicationDate = _license.IssueDate;
            application.ApplicationStatus = 1;
            application.ApplicantPersonID = clsPeople.GetClsPeopleByNationalNO(uscLicenseCardWithFilter1.clsLicenseCard1.latxtNationalNo.Text).PersonID;
            application.ApplicationTypeID = 6;
            application.CreatedByUserID = _license.CreatedByUserID;
            application.PaidFees = clsApplicationTypes.GetApplicationTypesInfoByID(6).ApplicationFees;
            application.LastStatusDate = DateTime.Now; ;

            if (clsLicense.Find(_license.IssuedUsingLocalLicenseID).LicenseClassID != 3)
            {
                MessageBox.Show("No");
            }
            else if(clsInternationalLicenses.IsExit(_license.IssuedUsingLocalLicenseID))
            {
                MessageBox.Show("He has International License with ID =  " + clsInternationalLicenses.FindByLocalID(_license.IssuedUsingLocalLicenseID).InternationalLicenseID );
            }
            else
            {

                if (application.Save())
                {
                    _license.ApplicationID = application.ApplicationID;
                    if (_license.Save())
                    {

                        MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        latxtLicenseID.Text = _license.InternationalLicenseID.ToString();
                        latxtApp.Text = application.ApplicationID.ToString();
                        linkLabelInfo.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Saved Failed.");
                    }
                }
                else
                {
                    MessageBox.Show("STOP");
                }
            }
        }
        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ID = clsPeople.GetClsPeopleByNationalNO(uscLicenseCardWithFilter1.clsLicenseCard1.latxtNationalNo.Text).PersonID;
            LicensesForm frm = new LicensesForm(ID);
            frm.ShowDialog();
        }

        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowInternationalLicense frm = new ShowInternationalLicense(_license.InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
