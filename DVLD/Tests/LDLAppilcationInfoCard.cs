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

namespace DVLD.Tests
{
    public partial class LDLAppilcationCard : UserControl
    {
        clsLocalDrivingLicenseApplication application;
        public LDLAppilcationCard()
        {
            InitializeComponent();
            application = new clsLocalDrivingLicenseApplication();
        }
        public void RefreshInfo( int _ID)
        {
             application = clsLocalDrivingLicenseApplication.FindByID(_ID);
            latxtAppID.Text = application.LocalDrivingLicenseApplicationID.ToString();
            latxtLicenseClass.Text = clsLicenseClass.Find(application.LicenseClassID).ClassName;
            latxtTest.Text = $"{clsTestAppointments.getCountPassedTest(_ID)}/3";
            latxtID.Text = application.ApplicationID.ToString();
            latxtDate.Text = application.ApplicationDate.ToString();
            latxtFees.Text = application.PaidFees.ToString();
            if (application.ApplicationStatus == 1)
            {
                latxtStatus.Text = "New";
            }
            else if (application.ApplicationStatus == 2)
            {
                latxtStatus.Text = "Cencelled";
            }
            else 
            { 
                        latxtStatus.Text = "Completed";
            }
            latxtStatusDate.Text = application.LastStatusDate.ToString();
            latxtUser.Text = clsUser.GetUserInfoByUserID(application.CreatedByUserID).UserName;
            latxtName.Text = clsPeople.ShowDetailsPerson(application.ApplicantPersonID).FullName;
            latxtType.Text = clsApplicationTypes.GetApplicationTypesInfoByID(application.ApplicationTypeID).ApplicationTypeTitle;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowDetailsPersonForm frm = new ShowDetailsPersonForm(application.ApplicantPersonID);
            frm.ShowDialog();
        }

        
    }
}
