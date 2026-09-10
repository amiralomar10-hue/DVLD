using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyValidationLibrary
{
    public static class clsValidating
    {

        public static bool ValidateEmpty(Control control, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider.SetError(control, "This field cannot be NULL");
                return false;
            }
            else
            {
                errorProvider.SetError(control, "");
                return true;
            }
        }

        public static bool ValidateEmail(TextBox txtEmail, ErrorProvider errorProvider)
        {
           
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtEmail.Text.Trim(), pattern))
            {
                errorProvider.SetError(txtEmail, "Invalid Email Format");
                return false;
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
                return true;
            }
        }


        public static bool ValidatePhone(TextBox txtPhone, ErrorProvider errorProvider)
        {
            if (!ValidateEmpty(txtPhone, errorProvider))
                return false;

            string pattern = @"^[0-9]+$";

            if (!Regex.IsMatch(txtPhone.Text.Trim(), pattern))
            {
                errorProvider.SetError(txtPhone, "Invalid Phone Number Format");
                return false;
            }
            else
            {
                errorProvider.SetError(txtPhone, "");
                return true;
            }
        }
        public static bool ValidatePasswordMatch(TextBox txtPassword, TextBox txtConfirmPassword, ErrorProvider errorProvider)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Passwords do not match");
                return false;
            }
            else
            {
                errorProvider.SetError(txtConfirmPassword, "");
                return true;
            }
        }

        public static bool ValidateCurrentPassword(TextBox txtCurrentPassword,string Password , ErrorProvider errorProvider)
        {
            if (txtCurrentPassword.Text != Password)
            {
                errorProvider.SetError(txtCurrentPassword, "Incorrect password");
                return false;
            }
            return true;
        }

        public static bool ValidatePersonID(TextBox txtPersonID, ErrorProvider errorProvider)
        {
            if (!ValidateEmpty(txtPersonID, errorProvider))
                return false;

            if (!int.TryParse(txtPersonID.Text.Trim(), out _))
            {
                errorProvider.SetError(txtPersonID, "Invalid Format, PersonID must be a number");
                return false;
            }
            else
            {
                errorProvider.SetError(txtPersonID, "");
                return true;
            }
        }
    }
}