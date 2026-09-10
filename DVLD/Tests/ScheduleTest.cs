using DVLD.Properties;
using DVLDBusinessLayer;
using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD.Tests
{
    public partial class ScheduleTest : Form
    {
        int _ID;
        int _TypeID;
        int _TestID;
        int _Count = 0;
        clsTestAppointments _Appointment = new clsTestAppointments();
        clsLocalDrivingLicenseApplication _local= new clsLocalDrivingLicenseApplication();
        public ScheduleTest(int iD, int typeID )
        {
            InitializeComponent();
            _ID = iD;
            _TypeID = typeID;
            _Count = clsTestAppointments.getCountFailedTest(_ID , _TypeID);
            _local = clsLocalDrivingLicenseApplication.FindByID(_ID);
            RefreshFormInfo();
            if (_Count!=0)
            {
                laTitle.Text = "Schedule Reatke Test";
                appointmentWithRetakeTest1.gbRetake.Enabled = true;
            }
        }

     
        public ScheduleTest(int iD, int typeID ,int TestID)
        {
            InitializeComponent();
            _ID = iD;
            _TypeID = typeID;
            _TestID = TestID;
            RefreshFormInfo();
            _Appointment = clsTestAppointments.Find(TestID);
            appointmentWithRetakeTest1.appointmentnfoCard1.dtpDate.Value = _Appointment.AppointmentDate;
            if (clsTestAppointments.Find(_TestID).IsLocked)
            {
                laRetake.Text = "Person already say for the test , appointment looked";
                groupBox1.Enabled = false;
                bSave.Enabled = false;

            }
        }

        public clsTestAppointments FillAppointmentInfo()
        {
            _Appointment.LocalDrivingLicenseApplicationID = _local.LocalDrivingLicenseApplicationID;
            _Appointment.AppointmentDate = appointmentWithRetakeTest1.appointmentnfoCard1.dtpDate.Value;
            _Appointment.CreatedByUserID = _local.CreatedByUserID;
            _Appointment.IsLocked = false;

            _Appointment.PaidFees = (appointmentWithRetakeTest1.gbRetake.Enabled == false) ? Convert.ToDecimal(appointmentWithRetakeTest1.appointmentnfoCard1.latxtFees.Text) : Convert.ToDecimal(appointmentWithRetakeTest1.latxtTotalFees.Text);
            _Appointment.TestTypeID = _TypeID;
            return _Appointment;
        }
        public void RefreshFormInfo()
        {

            switch (_TypeID)
            {
                case 1:
                    pictureBox1.Image = Resources.Vision_512;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    groupBox1.Text = "Vision Test";
                    
                    break;
                case 2:
     
                       pictureBox1.Image = Resources.Written_Test_512;
                       pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                     laTitle.Text = "Written Test Appointments";
                    break;
                case 3:
                  
                     pictureBox1.Image = Resources.wallpaper;
                     pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                     laTitle.Text = "Street Test Appointments";
                    break;
            }
            appointmentWithRetakeTest1.FillInfoCardWithREtake(_ID, _TypeID);

         }
        private void ScheduleTest_Load(object sender, EventArgs e)
        {

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            _Appointment = FillAppointmentInfo();
            if (_Count!=0)
            {
                _Appointment.RetakeTestApplicationID = _local.ApplicationID;
            }
            if (_Appointment.Save())
            {

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
               appointmentWithRetakeTest1.latxtTestAppID.Text = _Appointment.RetakeTestApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Data Saved Failed.");
            }
            appointmentWithRetakeTest1.latxtTestAppID.Text = (_Appointment.RetakeTestApplicationID != -1 ) ? _Appointment.RetakeTestApplicationID.ToString() : "N/A";
        }
    }
}
