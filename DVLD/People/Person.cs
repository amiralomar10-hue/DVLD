using DVLDBusinessLayer.Properties;
using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Global_Classes;
using DVLD.Global_Classes;
using System.IO;
using MyValidationLibrary;
using System.Resources;
using DVLD.Properties;

namespace DVLDBusinessLayer
{
    public partial class Person : UserControl
    {
        clsPeople people = new clsPeople();
        public Person()
        {
            InitializeComponent();
            linkRemove.Visible = false;

        }
        public void getAllComboBox()
        {
            comboBox.DataSource = CountriesData.getAllCountries();
            comboBox.DisplayMember = "CountryName";
            comboBox.ValueMember = "CountryID";
            comboBox.SelectedIndex = 168;
        }

        private void Person_Load(object sender, EventArgs e)
        {
            getAllComboBox();
            dateTimePicker.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateEmail(txtEmail, errorProvider))
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
            if (people.ImagePath == pictureBox.ImageLocation)
            {
                return true;
            }

         
            if (string.IsNullOrEmpty(pictureBox.ImageLocation))
            {
            
                if (!string.IsNullOrEmpty(people.ImagePath) && File.Exists(people.ImagePath))
                {
                    try
                    {
                        File.Delete(people.ImagePath);
                    }
                    catch { }
                }

                people.ImagePath = "";
                return true;
            }

            if (!string.IsNullOrEmpty(people.ImagePath) && File.Exists(people.ImagePath))
            {
                try
                {
                    File.Delete(people.ImagePath);
                }
                catch { }
            }

           
            string sourceFile = pictureBox.ImageLocation;

            if (clsUtil.CopyImageToProjectFolder(ref sourceFile))
            {
            
                people.ImagePath = sourceFile;
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
            if (!clsValidating.ValidateEmpty(txtFirstName , errorProvider))
            {
                e.Cancel = true;
            }
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateEmpty(txtSecondName, errorProvider))
            {
                e.Cancel = true;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateEmpty(txtLastName, errorProvider))
            {
                e.Cancel = true;
            }
        }

        private void txtAdd_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.ValidateEmpty(txtAdd, errorProvider))
            {
                e.Cancel = true;
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

        
    }
}




