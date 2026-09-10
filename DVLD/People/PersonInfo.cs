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
using System.Windows.Forms;
using DVLD.People;
using DVLD.Properties;
using DVLDBusinessLayer;
using DVLDBusinessLayer;
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
            person.Mode = enModePerson.AddNewMode;
        }
        public void GetPersonInfo()
        {
            person = clsPeople.ShowDetailsPerson(_ID);
            laID.Text = person.PersonID.ToString();
            USCPersonCard.txtNationalNo.Text = person.NationalNo;
            USCPersonCard.txtFirstName.Text = person.FirstName;
            USCPersonCard.txtSecondName.Text = person.SecondName;
            USCPersonCard.txtThirdName.Text = person.ThirdName;
            USCPersonCard.txtLastName.Text = person.LastName;
            USCPersonCard.dateTimePicker.Text = person.DateOfBirth.ToString();
            USCPersonCard.txtAdd.Text = person.Address.ToString();
            clsCountries countries = clsCountries.GetCountryName(person.NationalityCountryID);
            USCPersonCard.comboBox.SelectedValue = countries.CountryID;
            USCPersonCard.txtPhone.Text = person.Phone.ToString();
            USCPersonCard.txtEmail.Text = person.Email.ToString();
            USCPersonCard.pictureBox.ImageLocation = person.ImagePath;
            if (String.IsNullOrEmpty(USCPersonCard.pictureBox.ImageLocation))
            {
                USCPersonCard.pictureBox.Image = (USCPersonCard.rdMale.Checked) ? Resources.Male_512 : Resources.Female_512;
            }
            if ((person.Gender == (int)enGendor.Male))
            {
                USCPersonCard.rdMale.Checked = true;
            }
            else
            {
                USCPersonCard.rdFemale.Checked = true;
            }
        }
        public PersonInfo(int id)
        {
            InitializeComponent();
            _ID = id;
            person.Mode = enModePerson.UpdateMode;

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
            RefreshMode();
        }



        private void bClose_Click_1(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, person.PersonID);
            this.Close();
        }
        private void FillPersonInfo()
        {
            if (person == null)
                person = new clsPeople();

            person.NationalNo = USCPersonCard.txtNationalNo.Text.Trim();
            person.FirstName = USCPersonCard.txtFirstName.Text.Trim();
            person.SecondName = USCPersonCard.txtSecondName.Text.Trim();
            person.ThirdName = USCPersonCard.txtThirdName.Text.Trim();
            person.LastName = USCPersonCard.txtLastName.Text.Trim();
            person.Email = USCPersonCard.txtEmail.Text.Trim();
            person.Phone = USCPersonCard.txtPhone.Text.Trim(); 
            person.Address = USCPersonCard.txtAdd.Text.Trim();
            person.DateOfBirth = USCPersonCard.dateTimePicker.Value;

         
            person.Gender = USCPersonCard.rdMale.Checked ? 0 : 1;

            
            if (USCPersonCard.comboBox.SelectedValue != null)
            {
                person.NationalityCountryID = Convert.ToInt32(USCPersonCard.comboBox.SelectedValue);
            }

            
            person.ImagePath = string.IsNullOrEmpty(USCPersonCard.pictureBox.ImageLocation)
                               ? ""
                               : USCPersonCard.pictureBox.ImageLocation;
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
