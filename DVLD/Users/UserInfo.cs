using DVLDBusinessLayer;
using MyValidationLibrary;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class UserInfo : Form
    {
        private int _UserID = -1;
        private clsUser _User;

        public UserInfo()
        {
            InitializeComponent();
            _User = new clsUser();
            _User.Mode = clsUser.enMode.AddNew;
            uscPersonCardWithFilter1.IsFilter = true;
        }

        public UserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _User = clsUser.GetUserInfoByUserID(_UserID);
            _User.Mode = clsUser.enMode.Update;
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            RefreshMode();
        }

        private void RefreshMode()
        {
            if (_User.Mode == clsUser.enMode.AddNew)
            {
                laMode.Text = "Add New User";
                txtUserID.Text = "???";
                uscPersonCardWithFilter1.FilterEnabled = true;
            }
            else
            {
                laMode.Text = "Update User";
                txtUserID.Text = _User.UserID.ToString();
                uscPersonCardWithFilter1.FilterEnabled = false; // تعطيل الفلتر عند التعديل
                LoadUserInfo();
            }
        }

        public void LoadUserInfo()
        {
            if (_User == null)
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            uscPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            txtUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfimPassword.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (_User.Mode == clsUser.enMode.AddNew)
            {
                if (uscPersonCardWithFilter1.PersonID == -1)
                {
                    MessageBox.Show("Please select a valid person first!", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tabControl.SelectedIndex = 1;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool FillUserInfo()
        {
            if (uscPersonCardWithFilter1.PersonID == -1)
            {
                MessageBox.Show("Please select a person first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _User.PersonID = uscPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = cbIsActive.Checked;

            return true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!FillUserInfo())
                return;

            if (_User.Save())
            {
                txtUserID.Text = _User.UserID.ToString();
                _User.Mode = clsUser.enMode.Update;
                laMode.Text = "Update User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUserName, "Username cannot be blank");
            }
            else
            {
                errorProvider.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
            }
        }

        private void txtConfimPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfimPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider.SetError(txtConfimPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider.SetError(txtConfimPassword, "");
            }
        }
    }
}