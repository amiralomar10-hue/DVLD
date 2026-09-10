using DVLD;
using DVLD.Users;
using DVLD_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Golbal;
using DVLD.Applications;
using DVLD.Applicatios;
using DVLD.Drivers;
using DVLD.International;
using DVLD.Detain_Release;

namespace DVLDBusinessLayer
{

    public partial class MainForm : Form
    {
        private int _ID = Golbal.GolbalUser.CurrentUser.UserID;
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

    

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new PeopleForm();
            form.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new UserForm();
            form.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetailsUserForm form = new ShowDetailsUserForm(_ID);
            form.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword form = new ChangePassword(_ID);
            form.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

       

        private void mangeAplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationTypesForm frm = new ApplicationTypesForm();
            frm.ShowDialog();
        }

       

        private void mangeTextTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm frm = new TestForm();
            frm.ShowDialog();
        }

        private void LocalDrivingLicenseApplicationstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationForm frm = new ApplicationForm();
            frm.ShowDialog();
        }

        private void LocalLicensetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationInfo frm = new ApplicationInfo();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriversForm frm = new DriversForm();
            frm.ShowDialog();
        }

        private void InternationalLicensetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalInfo frm = new InternationalInfo();
            frm.ShowDialog();
        }

        private void InternationalLicesnseApplicationstoolStrpMenuItem_Click(object sender, EventArgs e)
        {
            MangeInternationalForm frm = new MangeInternationalForm();
            frm.ShowDialog();
        }

        private void RenewDrivingLicensetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicenseAppInfo frm = new RenewLicenseAppInfo();
            frm.ShowDialog();
        }

        private void ReplaceLicensestoolStripMenuItem_Click(object sender, EventArgs e)
        {
           ReplacementforDamagedorLostLicenses frm = new ReplacementforDamagedorLostLicenses();
                frm.ShowDialog();   
        }

        private void detainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainedLicenseForm frm = new ManageDetainedLicenseForm();
            frm.ShowDialog();
        }

        private void RetakeTasttoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReleaseDetainedtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseForm frm = new ReleaseForm();
        }

       
    }
}
