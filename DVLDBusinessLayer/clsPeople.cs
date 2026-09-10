using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDDataAccessLayer;
namespace DVLDBusinessLayer
{
    public enum enGendor
    {
        Male, Femail
    };
    public enum enModePerson
    {
        AddNewMode, UpdateMode
    }

    public class clsPeople
    {


        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }    
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public clsCountries countries;
        public enModePerson Mode { get; set; }

        public clsPeople()
        {
            PersonID = -1;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            FullName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gender = 0;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NationalityCountryID = -1;
            ImagePath = string.Empty;
            Mode = enModePerson.AddNewMode;
        }



        private clsPeople(int personID, string nationalNo, string firstName, string secondName, string thirdName,
                      string lastName, DateTime dateOfBirth, int gender, string address,
                      string phone, string email, int nationalityCountryID, string imagePath, enModePerson mode)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.FullName = $"{FirstName} {SecondName} {ThirdName} {lastName}";
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;
            this.Mode = mode;
          countries = clsCountries.GetCountryName(NationalityCountryID);
        }


        public static DataTable getAllPeople()
        {
            return PeopleData.getAllPeople();
        }

        private bool _AddNewPeople()
        {
            PersonID = DVLDDataAccessLayer.PeopleData.AddNewPeople(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

            return (PersonID != -1);
        }
        public static clsPeople GetClsPeopleByNationalNO(string nationalNo)
        {

            int personID = -1;
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.Now;
            int gender = -1;
            string address = "";
            string phone = "";
            string email = "";
            int nationalityCountryID = -1;
            string imagePath = "";
            if (DVLDDataAccessLayer.PeopleData.GetPersonByNationalNo( nationalNo,ref personID, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new clsPeople(personID,nationalNo, firstName, secondName, thirdName, lastName, dateOfBirth, gender, address, phone, email, nationalityCountryID, imagePath, enModePerson.UpdateMode);
            }

            return new clsPeople();
        }


        public static clsPeople ShowDetailsPerson(int personID)
        {
            string nationalNo = "";
            string firstName = "";
            string secondName = ""; 
            string thirdName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.Now;
            int gender = -1; 
            string address = "";
            string phone = "";
            string email = "";
            int nationalityCountryID = -1;
            string imagePath = "";
            if (DVLDDataAccessLayer.PeopleData.getPersonByPersonID(personID, ref nationalNo, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new clsPeople(personID,nationalNo , firstName , secondName , thirdName , lastName , dateOfBirth , gender , address , phone , email  , nationalityCountryID , imagePath , enModePerson.UpdateMode);
            }

            return new clsPeople(); 
        }

        private bool _UpadtePeople()
        {
            return PeopleData.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Email, Gender, Phone, Address, NationalityCountryID, DateOfBirth, ImagePath);
        }
        public bool Save()
        {

            switch (Mode)
            {
                case enModePerson.AddNewMode:
                    return _AddNewPeople();

                case enModePerson.UpdateMode:
                    return _UpadtePeople();

            }
            return false;
        }

        public static bool DeletePeople(int personID)
        {
            return PeopleData.DeletePerson(personID);
        }

        public static bool IsExist(string NationalNo)
        {
            return PeopleData.IsExistPerson(NationalNo);
        }
        public static bool IsExist(int Person)
        {
            return PeopleData.IsExistPerson(Person);
        }
       
    }
}
