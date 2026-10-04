using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ValidationAttributes;

namespace MyValidationLibrary
{
    public static class clsValidating
    {
        public static bool ValidateFormWithAttributes(Form form, object model, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            bool isValid = true;

            if (model == null) return true;

            Type type = model.GetType();

            foreach (PropertyInfo prop in type.GetProperties())
            {
                object value = prop.GetValue(model);

                Control[] controls = form.Controls.Find("txt" + prop.Name, true);
                if (controls.Length == 0) continue;

                Control targetControl = controls[0];

                var reqAttr = prop.GetCustomAttribute<RequiredAttribute>();
                if (reqAttr != null && (value == null || string.IsNullOrWhiteSpace(value.ToString())))
                {
                    errorProvider.SetError(targetControl, reqAttr.ErrorMessage);
                    isValid = false;
                }

                var lenAttr = prop.GetCustomAttribute<StringLengthAttribute>();
                if (lenAttr != null && value is string strVal && !string.IsNullOrEmpty(strVal))
                {
                    if (strVal.Length < lenAttr.Min || strVal.Length > lenAttr.Max)
                    {
                        errorProvider.SetError(targetControl, lenAttr.ErrorMessage);
                        isValid = false;
                    }
                }

                var regexAttr = prop.GetCustomAttribute<RegularExpressionAttribute>();
                if (regexAttr != null && value != null && !string.IsNullOrEmpty(value.ToString()))
                {
                    if (!Regex.IsMatch(value.ToString(), regexAttr.Pattern))
                    {
                        errorProvider.SetError(targetControl, regexAttr.ErrorMessage);
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

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

        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            return regex.IsMatch(emailAddress);
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

        // مطابقة كلمة السر الجديدة مع حقل التأكيد
        public static bool ValidatePasswordMatch(TextBox txtPassword, TextBox txtConfirmPassword, ErrorProvider errorProvider)
        {
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
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
        // التحقق من كلمة السر الحالية (تشفير المدخل لمقارنته مع الـ Hash المخزن)
        public static bool ValidateCurrentPassword(TextBox txtCurrentPassword, string hashedCurrentPasswordFromDB, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                errorProvider.SetError(txtCurrentPassword, "Current password cannot be empty");
                return false;
            }

            // 1. تشفير كلمة السر المدخلة حالياً
            string hashedInput = clsSecurity.ComputeHash(txtCurrentPassword.Text.Trim());

            // 2. مقارنة الـ Hash المدخل مع الـ Hash القديم في الداتا بيز
            if (hashedInput != hashedCurrentPasswordFromDB)
            {
                errorProvider.SetError(txtCurrentPassword, "Incorrect current password");
                return false;
            }
            else
            {
                errorProvider.SetError(txtCurrentPassword, "");
                return true;
            }
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

        public static void AttachAutoValidation(Control parentControl, object entity, ErrorProvider errorProvider)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Validating += (sender, e) =>
                    {
                        ValidateSingleControl(txt, entity, errorProvider);
                    };
                }

                if (control.HasChildren)
                {
                    AttachAutoValidation(control, entity, errorProvider);
                }
            }
        }

        private static void ValidateSingleControl(TextBox txt, object entity, ErrorProvider errorProvider)
        {
            string propertyName = txt.Name.StartsWith("txt") ? txt.Name.Substring(3) : txt.Name;
            var property = entity.GetType().GetProperty(propertyName);

            if (property != null)
            {
                var requiredAttr = property.GetCustomAttribute<RequiredAttribute>();
                if (requiredAttr != null && string.IsNullOrWhiteSpace(txt.Text))
                {
                    errorProvider.SetError(txt, requiredAttr.ErrorMessage);
                }
                else
                {
                    errorProvider.SetError(txt, "");
                }
            }
        }
    }
}