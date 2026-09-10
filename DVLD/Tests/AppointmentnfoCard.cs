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
    public partial class AppointmentnfoCard : UserControl
    {
        public AppointmentnfoCard()
        {
            InitializeComponent();
        }
        public void FillAppointmentInfoCard(int ID , int TypeID) 
        {
            latxtAppID.Text = ID.ToString();
            latxtClass.Text = clsLicenseClass.Find(clsLocalDrivingLicenseApplication.FindByID(ID).LicenseClassID).ClassName;
            latxtFees.Text = clsTestType.Find(TypeID).Fees.ToString();
            latxtName.Text = latxtName.Text = clsPeople.ShowDetailsPerson(clsLocalDrivingLicenseApplication.FindByID(ID).ApplicantPersonID).FullName;
            latxtTrial.Text = clsTestAppointments.getCountFailedTest(ID, TypeID).ToString();
            dtpDate.Text = DateTime.Now.ToShortDateString();
        }

        
    }
}
