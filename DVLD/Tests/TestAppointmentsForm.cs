using DVLD.Properties;
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

namespace DVLD.Tests
{
    public partial class TestAppointmentsForm : Form
    {
        int _ID;
        clsTestType _clsTestType;
        int _typeID;
        int TestID;
        clsTestAppointments _TestAppointment = new clsTestAppointments();
        DataTable dtAppointments = new DataTable();
        public TestAppointmentsForm(int ID , int TypeID)
        {
            InitializeComponent();
            _ID = ID;
            _typeID = TypeID;
            RefreshFormInfo();
        
        }
        public void RefreshListAppointments(int ID,int TestTypeID)
        {
            dtAppointments = clsTestAppointments.GetTestAppointmentByIDAndTestType(ID , TestTypeID);
            dataGridView1.DataSource = dtAppointments;
            laCountRecords.Text = dataGridView1.Rows.Count.ToString();
        }
        public void RefreshFormInfo() {

            switch (_typeID)
            {
                case 1:
                    this.Text = "Vision Test Appointments";
                    pictureBox.Image = Resources.Vision_512;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    laTitle.Text = "Vision Test Appointments";
                    break;
                case 2:
                   this.Text = "Written Test Appointments";
                    pictureBox.Image = Resources.Written_Test_512;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    laTitle.Text = "Written Test Appointments";
                    break;
                case 3:
                    this.Text = "Street Test Appointments";
                    pictureBox.Image = Resources.wallpaper;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    laTitle.Text = "Street Test Appointments";
                    break;
            }
            RefreshListAppointments(_ID , _typeID);
            ldlAppilcationCard1.RefreshInfo(_ID);
        }

   

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (clsTestAppointments.IsExist(_ID))
            {
                MessageBox.Show("Person already have an active appointment for this test , You cannot add new appointments","Not allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                ScheduleTest frm = new ScheduleTest(_ID, _typeID);
                frm.ShowDialog();
                RefreshListAppointments(_ID, _typeID);
            }
            
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
             TestID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
             TakeTest frm = new TakeTest(TestID,_typeID);
            TakeTest.DataBack += PassedTest;
            frm.ShowDialog();
            _TestAppointment = clsTestAppointments.Find(TestID);
            _TestAppointment.LookTest();
           
            RefreshListAppointments(_ID, _typeID);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
             TestID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); 
            ScheduleTest frm = new ScheduleTest(_ID , _typeID , TestID);
            frm.ShowDialog();

            RefreshListAppointments(_ID, _typeID);
        }
        private void PassedTest(object sender, bool Res)
        {
            if (Res)
            {
                bAdd.Enabled = false;
            }
        }
    }
}
