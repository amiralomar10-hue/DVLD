using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyValidationLibrary;
using System.Resources;
using System.Windows.Forms;
using DVLD.Global_Classes;
using DVLD.People;
using DVLD.Properties;
using DVLDBusinessLayer;
using DVLDDataAccessLayer;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountries.GetAllCountries();

            comboBox.DataSource = dtCountries;
                comboBox.DisplayMember = "CountryName"; // اسم العمود كما هو في قاعدة البيانات
            comboBox.ValueMember = "CountryID";     // اسم عمود الـ ID

            comboBox.SelectedIndex = 168;
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidatePhone(txtPhone, errorProvider))
            {
                e.Cancel = true;
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
                    try
                    {
                        File.Delete(person.ImagePath);
                    }
                    catch { }
                }

                person.ImagePath = "";
                return true;
            }

            if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
            {
                try
                {
                    File.Delete(person.ImagePath);
                }
                catch { }
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

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPeople.IsExist(txtNationalNo.Text))
            {
                errorProvider.SetError(txtNationalNo, "Person is already exists");
            }
            else
            {
                errorProvider.SetError(txtNationalNo, "");
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateEmpty(txtFirstName, errorProvider))
            {
                e.Cancel = true;
            }
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateEmpty(txtSecondName, errorProvider))
            {
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateEmpty(txtLastName, errorProvider))
            {
            }
        }

        private void txtAdd_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateEmpty(txtAdd, errorProvider))
            {
            }
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
            txtAdd.Text = person.Address.ToString();
            clsCountries countries = person.CountryInfo;
            comboBox.SelectedValue = countries.CountryID;
            txtPhone.Text = person.Phone.ToString();
            txtEmail.Text = person.Email.ToString();
            pictureBox.ImageLocation = person.ImagePath;
            if (String.IsNullOrEmpty(pictureBox.ImageLocation))
            {
                pictureBox.Image = (rdMale.Checked) ? Resources.Male_512 : Resources.Female_512;
            }
            if ((person.Gender == (int)enGendor.Male))
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
        }
        public PersonInfo(int id)
        {
            InitializeComponent();
            _ID = id;
            person.Mode = enModePerson.UpdateMode;
            linkRemove.Visible = true;
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
            person.Email =  txtEmail.Text.Trim();
            person.Phone = txtPhone.Text.Trim(); 
            person.Address = txtAdd.Text.Trim();
            person.DateOfBirth = dateTimePicker.Value;

         
            person.Gender = rdMale.Checked ? 0 : 1;

            
            if (comboBox.SelectedValue != null)
            {
                person.NationalityCountryID = Convert.ToInt32(comboBox.SelectedValue);
            }

            
            person.ImagePath = string.IsNullOrEmpty(pictureBox.ImageLocation)
                               ? ""
                               : pictureBox.ImageLocation;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
         
            try
            {
                FillPersonInfo();

                if (person.Save())
                {
                    laID.Text = person.PersonID.ToString();
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshMode();
                    HandlePictureImage();
                    DataBack?.Invoke(this, person.PersonID);

                }
                else
                {
                    MessageBox.Show("Data Save Failed. Check if NationalNo already exists.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex1)
            {
                MessageBox.Show($"Database Error: {ex1.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex2)
            {
                MessageBox.Show($"An error occurred: {ex2.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    }
}
