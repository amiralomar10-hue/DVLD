using System;
using System.Windows.Forms;
using DVLDBusinessLayer;
using Microsoft.Win32;


namespace DVLD_Interface
{
    public partial class frmLogin : Form
    {
        clsUser User;

        string keyPath =  @"HKEY_CURRENT_USER\Software\DVLD";

        string valueName = "Loggin Info";
        string valueData = "";

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
                // Read the value from the Registry
                string value = Registry.GetValue(keyPath, valueName, null) as string;


                if (value != null)
                {

                    User = clsUser._ConvertLinetoUserObject(value);
                    txtUsername.Text = User.UserName;
                    txtPassword.Text = User.Password;
                }
                else
                {
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
                string subKeyPath = @"Software\DVLD";

                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(subKeyPath, true))
                    {
                        if (key != null)
                        {
                            if (key.GetValue(valueName) != null)
                            {
                                key.DeleteValue(valueName);
                            }
                        }
                    }
                }

                txtUsername.Clear();
                txtPassword.Clear();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("UnauthorizedAccessException: Run the program with administrative privileges.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveLogin()
        {

            valueData = clsUser._ConverUserObjectToLine(User);

            try
            {
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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