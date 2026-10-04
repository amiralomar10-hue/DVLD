using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using MyValidationLibrary;
using System.Windows.Forms;
using ValidationAttributes.Global_Classes;
using DVLD.Properties;
using Golbal;
using System.ComponentModel;
using LogEvent;

namespace DVLDBusinessLayer
{
    public partial class PersonInfo : Form
    {
        int _ID;
        clsPeople person = new clsPeople();

        public delegate void DataBackEvent(object sender, int personID);
        public event DataBackEvent DataBack;

        public PersonInfo()
        {
            InitializeComponent();
            this.Load += PersonInfo_Load;
            person.Mode = enModePerson.AddNewMode;
        }

        public PersonInfo(int id)
        {
            InitializeComponent();
            _ID = id;
            person.Mode = enModePerson.UpdateMode;
            linkRemove.Visible = true;
        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountries.GetAllCountries();

            comboBox.DataSource = dtCountries;
            comboBox.DisplayMember = "CountryName";
            comboBox.ValueMember = "CountryID";

            comboBox.SelectedIndex = 168;
        }

        // =========================================================================
        //  فحص تكرار الرقم الوطني مباشرة أثناء الكتابة (Unique Validation)
        // =========================================================================
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            // نفحص التكرار فقط إذا كان الشخص جديداً أو غير الرقم الوطني
            if (person.Mode == enModePerson.AddNewMode && clsPeople.IsExist(txtNationalNo.Text.Trim()))
            {
                errorProvider.SetError(txtNationalNo, "Person with this National No already exists!");
            }
            else
            {
                errorProvider.SetError(txtNationalNo, "");
            }
        }

        public bool HandlePictureImage()
        {
            if (person.ImagePath == pictureBox.ImageLocation)
            {
                return true;
            }

            if (string.IsNullOrEmpty(pictureBox.ImageLocation))
            {
                if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
                {
                    try { File.Delete(person.ImagePath); } catch { }
                }

                person.ImagePath = "";
                return true;
            }

            if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
            {
                try { File.Delete(person.ImagePath); } catch { }
            }

            string sourceFile = pictureBox.ImageLocation;

            if (clsUtil.CopyImageToProjectFolder(ref sourceFile))
            {
                person.ImagePath = sourceFile;
                return true;
            }

            return false;
        }

        private void linkLaSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string seletedFilePath = openFileDialog1.FileName;
                pictureBox.ImageLocation = seletedFilePath;
                linkRemove.Visible = true;
            }
        }

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox.ImageLocation = null;
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMale.Checked)
            {
                pictureBox.Image = Resources.Male_512;
            }
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFemale.Checked)
            {
                pictureBox.Image = Resources.Female_512;
            }
        }
        public void GetPersonInfo()
        {
            person = clsPeople.ShowDetailsPerson(_ID);
            laID.Text = person.PersonID.ToString();
            txtNationalNo.Text = person.NationalNo;
            txtFirstName.Text = person.FirstName;
            txtSecondName.Text = person.SecondName;
            txtThirdName.Text = person.ThirdName;
            txtLastName.Text = person.LastName;
            dateTimePicker.Text = person.DateOfBirth.ToString();
            txtAddress.Text = person.Address; // تم استخدام txtAddress بدلاً من txtAdd

            clsCountries countries = person.CountryInfo;
            if (countries != null)
                comboBox.SelectedValue = countries.CountryID;

            txtPhone.Text = person.Phone;
            txtEmail.Text = person.Email;
            pictureBox.ImageLocation = person.ImagePath;

            if (String.IsNullOrEmpty(pictureBox.ImageLocation))
            {
                pictureBox.Image = (person.Gender == 0) ? Resources.Male_512 : Resources.Female_512;
            }

            if (person.Gender == (int)enGendor.Male)
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
        }

        private void RefreshMode()
        {
            if (person.Mode == enModePerson.AddNewMode)
            {
                laMode.Text = "Add New Person";
            }
            else
            {
                GetPersonInfo();
                laMode.Text = "Update Person";
            }

            if (person.PersonID != -1)
            {
                laID.Text = person.PersonID.ToString();
            }
            else
            {
                laID.Text = "N/A";
            }
        }

        private void PersonInfo_Load(object sender, EventArgs e)
        {
            _FillCountriesInComoboBox();
            dateTimePicker.MaxDate = DateTime.Today.AddYears(-18);
            clsValidating.AttachAutoValidation(this, person, errorProvider);
            RefreshMode();
        }

        private void bClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillPersonInfo()
        {
            if (person == null)
                person = new clsPeople();

            person.NationalNo = txtNationalNo.Text.Trim();
            person.FirstName = txtFirstName.Text.Trim();
            person.SecondName = txtSecondName.Text.Trim();
            person.ThirdName = txtThirdName.Text.Trim();
            person.LastName = txtLastName.Text.Trim();
            person.Email = txtEmail.Text.Trim();
            person.Phone = txtPhone.Text.Trim();
            person.Address = txtAddress.Text.Trim(); // تم التعديل إلى txtAddress
            person.DateOfBirth = dateTimePicker.Value;
            person.Gender = rdMale.Checked ? 0 : 1;

            if (comboBox.SelectedValue != null)
            {
                person.NationalityCountryID = Convert.ToInt32(comboBox.SelectedValue);
            }

            person.ImagePath = string.IsNullOrEmpty(pictureBox.ImageLocation) ? "" : pictureBox.ImageLocation;
        }

        // =========================================================================
        //  زر الحفظ المطور باستدعاء محرك الـ Reflection & Attributes
        // =========================================================================
        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. تعبئة الكائن ببيانات الشاشة
                FillPersonInfo();

                // 2. الفحص التلقائي بالـ Reflection والـ Attributes (سطر واحد فقط)
                if (!clsValidating.ValidateFormWithAttributes(this, person, errorProvider))
                {
                    MessageBox.Show("Some fields are not valid! Please check the red icon error messages.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // 3. التأكد من عدم تكرار الرقم الوطني عند الإضافة
                if (person.Mode == enModePerson.AddNewMode && clsPeople.IsExist(person.NationalNo))
                {
                    errorProvider.SetError(txtNationalNo, "National Number already exists!");
                    MessageBox.Show("National Number already exists in the system.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4. الحفظ في قاعدة البيانات
                if (person.Save())
                {
                    laID.Text = person.PersonID.ToString();
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HandlePictureImage();
                    RefreshMode();

                    DataBack?.Invoke(this, person.PersonID);
                }
                else
                {
                    MessageBox.Show("Data Save Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex1)
            {
                clsLogEvent.LogError(ex1 , $"Database Error: {ex1}");
                MessageBox.Show($"Database Error: {ex1.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex2)
            {
                clsLogEvent.LogError(ex2, $"Database Error: {ex2}");
                MessageBox.Show($"An error occurred: {ex2.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}