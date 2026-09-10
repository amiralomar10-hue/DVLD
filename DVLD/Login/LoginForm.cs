using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DVLDBusinessLayer;
using DVLDBusinessLayer;
using Golbal;
namespace DVLD_Interface
{
    public partial class frmLogin : Form
    {
        clsUser User;
        FileInfo logFile = new FileInfo("Login_File.txt");

        public frmLogin()
        {
            InitializeComponent();
            FillTextBoxes();
        }
    
       private void Form1_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
          }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            this.CancelButton = btnClose;
            this.KeyPreview = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84) 
            {
                m.Result = (IntPtr)0x2; 
            }
        }

        private void FillTextBoxes()
        {
            try
            {
                if (logFile.Exists)
                {
                    using (StreamReader sr = logFile.OpenText())
                    {
                        string line = sr.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            User = clsUser._ConvertLinetoUserObject(line);
                            if (User != null)
                            {
                                txtUsername.Text = User.UserName;
                                txtPassword.Text = User.Password;
                                chkRememberMe.Checked = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                
            }
        }

        private void CleanTextBoxes()
        {
            try
            {
                if (logFile.Exists)
                {
                    logFile.Delete();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private bool SaveLogin()
        {
            try
            {
                using (StreamWriter writer = logFile.CreateText())
                {
                    if (User != null)
                    {
                        writer.WriteLine(clsUser._ConverUserObjectToLine(User));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving login data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User = clsUser.GetUserInfoByUserNameAndPassword(txtUsername.Text, txtPassword.Text);

            if (User != null)
            {
                if (!User.IsActive)
                {
                    MessageBox.Show("Your account is not active, please contact your admin.", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (chkRememberMe.Checked)
                {
                    if (SaveLogin())
                    {
                        Golbal.GolbalUser.CurrentUser = User;
                        this.Hide();
                        MainForm form = new MainForm();
                        form.ShowDialog();
                    }
                }
                else
                {
                    Golbal.GolbalUser.CurrentUser = User;
                    CleanTextBoxes();
                    this.Hide();
                    MainForm form = new MainForm();
                    form.ShowDialog();
                }


            }
            else
            {
                MessageBox.Show("Invalid Username / Password!", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}