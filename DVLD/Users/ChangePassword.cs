using System;
using System.ComponentModel;
using System.Windows.Forms;
using DVLDBusinessLayer;
using MyValidationLibrary;

namespace ValidationAttributes.Users
{
    public partial class ChangePassword : Form
    {
        private int _UserID = -1;
        private clsUser _User;

        public ChangePassword(int ID)
        {
            InitializeComponent();
            _UserID = ID;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            // جلب بيانات المستخدم من الداتا بيز للحصول على كلمة السر المشفّرة القديمة
            _User = clsUser.GetUserInfoByUserID(_UserID);
            uscUserInfo1.LoadUserInfo(_UserID);
        }

        private bool FillUserInfo()
        {
            if (_User == null) return false;

            // تشفير كلمة السر الجديدة قبل الحفظ
            string newHashedPassword = clsSecurity.ComputeHash(txtNewPassword.Text.Trim());
            _User.Password = newHashedPassword;
            return true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            // تفعيل التحقق من جميع عناصر الشاشة أولاً
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!FillUserInfo()) return;

            if (_User.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_User == null) return;

            // استخدام دالة الفحص مع الـ Hash الخاص بالمستخدم
            if (!clsValidating.ValidateCurrentPassword(txtCurrentPassword, _User.Password, errorProvider1))
            {
                e.Cancel = true;
            }
        }

        private void txtConfimPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidatePasswordMatch(txtNewPassword, txtConfimPassword, errorProvider1))
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