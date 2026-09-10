using DVLD.Properties;
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
    public partial class TakeTest : Form
    {
        int _ID;
        int _TypeID;
        clsTests test = new clsTests();
        public delegate void TakeTestDelegate(object sender , bool Res);
        public static TakeTestDelegate DataBack;
        public TakeTest(int iD, int typeID)
        {
            InitializeComponent();
            _ID = iD;
            _TypeID = typeID;
            RefreshFormInfo();
        }
        public void RefreshFormInfo()
        {
            pictureBox1.Image = Resources.Vision_512;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            groupBox1.Text = "Vision Test";
            appointmentnfoCard1.FillAppointmentInfoCard(clsTestAppointments.Find(_ID).LocalDrivingLicenseApplicationID , _TypeID);
            appointmentnfoCard1.dtpDate.Value = clsTestAppointments.Find(_ID).AppointmentDate;
            appointmentnfoCard1.latxtFees.Text = clsTestAppointments.Find (_ID).PaidFees.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            test.TestResult = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            test.TestResult = false; 
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            test.Notes = txtNotes.Text;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(sender, test.TestResult);
            this.Close();
        }
        public clsTests FillTestInfo()
        {
            clsTests T = new clsTests();
            T.CreatedByUserID = clsTestAppointments.Find(_ID).CreatedByUserID;
            T.TestAppointmentID = _ID;
            T.TestResult = (radioButton1.Checked) ? true : false;
            T.Notes = (!String.IsNullOrEmpty(txtNotes.Text))? txtNotes.Text : "";
            return T;
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            test = FillTestInfo();
            if (test.Save())
            {

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                latxtTestID.Text = test.TestID.ToString();

            }
            else
            {
                MessageBox.Show("Data Saved Failed.");
            }
        }

       
    }
}
