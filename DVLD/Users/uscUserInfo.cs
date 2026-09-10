using DVLDBusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class uscUserInfo : UserControl
    {
        private int _UserID = -1;
        private clsUser _User;
        public string Password;
        public int UserID => _UserID;

        public uscUserInfo()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
            _User = clsUser.GetUserInfoByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            
            uscPersonCard1.GetPersonInfo(_User.PersonID);

       
            latxtUserID.Text = _User.UserID.ToString();
            latxtUserName.Text = _User.UserName;
            latxtIsActive.Text = _User.IsActive ? "Yes" : "No";
            Password = _User.Password;
        }
    }
}