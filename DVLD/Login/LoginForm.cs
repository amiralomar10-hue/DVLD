using System;
using System.Windows.Forms;
using DVLDBusinessLayer;
using Microsoft.Win32;

namespace DVLD_Interface
{
    public partial class frmLogin : Form
    {
        clsUser User;

        string keyPath = @"HKEY_CURRENT_USER\Software\DVLD";
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
                // 1. قراءة النص المشفر من الـ Registry
                string encryptedValue = Registry.GetValue(keyPath, valueName, null) as string;

                if (!string.IsNullOrEmpty(encryptedValue))
                {
                    // 2. فك التشفير المتناظر (Symmetric Decryption)
                    string decryptedValue = clsSecurity.DecryptText(encryptedValue);

                    // 3. تحويل النص بعد فك التشفير إلى كائن User
                    User = clsUser._ConvertLinetoUserObject(decryptedValue);

                    if (User != null)
                    {
                        txtUsername.Text = User.UserName;
                        txtPassword.Text = User.Password; // كلمة السر الصريحة
                        chkRememberMe.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // إمكانية تسجيل الأخطاء هنا
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
            try
            {
                // الاحتفاظ بكلمة السر الصريحة في الكائن قبل التجميع حتى يتم إعادتها للتكست بوكس لاحقاً
                User.Password = txtPassword.Text.Trim();

                // 1. تحويل بيانات المستخدم لسطر نصي
                string lineData = clsUser._ConverUserObjectToLine(User);
                // 2. تشفير السطر بالتشفير المتناظر (Symmetric Encryption)
                string encryptedData = clsSecurity.EncryptText(lineData);
                // 3. حفظ النص المشفر في الـ Registry
                Registry.SetValue(keyPath, valueName, encryptedData, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. تحويل كلمة السر المدخلة إلى Hash (SHA-256) لمطابقتها مع الداتا بيز
            string hashedPassword = clsSecurity.ComputeHash(txtPassword.Text.Trim());

            // 2. البحث في قاعدة البيانات عن اسم المستخدم مع الـ Hashed Password
            User = clsUser.GetUserInfoByUserNameAndPassword(txtUsername.Text.Trim(), hashedPassword);

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