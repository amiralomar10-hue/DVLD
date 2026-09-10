using DVLD.Properties;
using DVLDBusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class USCPersonCard : UserControl
    {
        private int _ID = -1;
        private clsPeople _personInfo;

        public int PersonID => _ID;
        public clsPeople PersonInfo => _personInfo;

        public USCPersonCard()
        {
            InitializeComponent();
        }

        
        public void ResetPersonInfo()
        {
            _ID = -1;
            _personInfo = null;
            latxtPersonID.Text = "[???]";
            LatxtNationalNO.Text = "[???]";
            latxtName.Text = "[???]";
            latxtDateOfBirth.Text = "[???]";
            latxtAddress.Text = "[???]";
            latxtCountry.Text = "[???]";
            latxtPhone.Text = "[???]";
            latxtEmail.Text = "[???]";
            latxtGendor.Text = "[???]";
            pictureBox.Image = Resources.Male_512;
        }

        private void _FillPersonInfo()
        {
            _ID = _personInfo.PersonID;
            latxtPersonID.Text = _personInfo.PersonID.ToString();
            LatxtNationalNO.Text = _personInfo.NationalNo;
            latxtName.Text = $"{_personInfo.FirstName} {_personInfo.SecondName} {_personInfo.ThirdName} {_personInfo.LastName}";
            latxtDateOfBirth.Text = _personInfo.DateOfBirth.ToShortDateString();
            latxtAddress.Text = _personInfo.Address;

            clsCountries countries = clsCountries.GetCountryName(_personInfo.NationalityCountryID);
            latxtCountry.Text = (countries != null) ? countries.CountryName : "[???]";

            latxtPhone.Text = _personInfo.Phone;
            latxtEmail.Text = _personInfo.Email;
            latxtGendor.Text = (_personInfo.Gender == (int)enGendor.Male) ? "Male" : "Female";

            if (!string.IsNullOrEmpty(_personInfo.ImagePath))
            {
                pictureBox.ImageLocation = _personInfo.ImagePath;
            }
            else
            {
                pictureBox.Image = (_personInfo.Gender == (int)enGendor.Male) ? Resources.Male_512 : Resources.Female_512;
            }
        }

        public void GetPersonInfo(int ID)
        {
            _personInfo = clsPeople.ShowDetailsPerson(ID);
            if (_personInfo == null)
            {
                ResetPersonInfo();
                MessageBox.Show($"No Person with PersonID = {ID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }

        public void GetPersonInfo(string NationalNo)
        {
            _personInfo = clsPeople.GetClsPeopleByNationalNO(NationalNo);
            if (_personInfo == null)
            {
                ResetPersonInfo();
                MessageBox.Show($"No Person with NationalNo = {NationalNo}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }

        private void linkLaSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_ID != -1)
            {
                Form form = new PersonInfo(_ID);
                form.ShowDialog();
                GetPersonInfo(_ID);     
            }
        }
    }
}