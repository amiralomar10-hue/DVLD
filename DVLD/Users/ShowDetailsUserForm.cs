using System;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class ShowDetailsUserForm : Form
    {
        private int _UserID;

        public ShowDetailsUserForm(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void ShowDetailsUserForm_Load(object sender, EventArgs e)
        {
            uscUserInfo1.LoadUserInfo(_UserID);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}