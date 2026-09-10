using DVLD.People;
using DVLDBusinessLayer;
using MyValidationLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class ChangePassword : Form
    {
        int _UserID = -1;
        clsUser User = new clsUser();
       public ChangePassword(int ID)
        {
            InitializeComponent();
           _UserID = ID;
        }
        private clsUser FillUserInfo()
        {

            clsUser user = new clsUser();
            user = clsUser.GetUserInfoByUserID(_UserID);
            user.Password = txtNewPassword.Text.Trim();
            return user;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
           User = FillUserInfo();

            if (User.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Saved Failed.");
            }
        }

    

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            uscUserInfo1.LoadUserInfo(_UserID);

        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateCurrentPassword(txtCurrentPassword, uscUserInfo1.Password, errorProvider1))
            {
                e.Cancel = true;
            }
        }

        private void txtConfimPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidatePasswordMatch(txtNewPassword , txtConfimPassword , errorProvider1))
            {
                e.Cancel = true;
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
