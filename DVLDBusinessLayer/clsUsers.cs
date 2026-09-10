using System;
using System.Data;
using DVLD.Global_Classes;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;

            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        public static clsUser GetUserInfoByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            if (clsUserData.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExistForUserID(UserID);
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }
        public static bool IsUserExistForUserNameAndPassWord(string UserName , string Password)
        {
            return clsUserData.IsUserExistForUserNameAndPassWord(UserName , Password);
        }

        public static DataTable GetAllUsersIsActive()
        {
            return clsUserData.GetAllUsersIsActive();
        }

        public static DataTable GetUsersIsNotActive() { 
        
            return clsUserData.GetAllUsersIsNotActive();
        }
        public static clsUser GetUserInfoByUserNameAndPassword(string UserName ,string Password)
        {
            int UserID = -1;
            int PersonID = -1;
          
            if (clsUserData.GetUserInfoByUserNameAndPassword(UserName ,Password ,ref UserID, ref PersonID))
            {
                return new clsUser(UserID, PersonID, UserName, Password, true);
            }
            else
            {
                return null;
            }
        }
        public static clsUser _ConvertLinetoUserObject(string Line, string Seperator = "#//#")
        {
            if (string.IsNullOrWhiteSpace(Line))
                return null;

            string[] vUserData = Line.Split(new string[] { Seperator }, StringSplitOptions.None);

            // حماية: التأكد من أن السطر يحتوي على جميع الحقول الخمسة المطلوبة
            if (vUserData.Length < 5)
                return null;

            return new clsUser(
                Convert.ToInt32(vUserData[0]),         // UserID
                Convert.ToInt32(vUserData[1]),         // PersonID
                vUserData[2],                          // UserName
                clsUtil.DecryptText(vUserData[3]),     // Password
                Convert.ToBoolean(vUserData[4])        // IsActive
            );
        }

        public static string _ConverUserObjectToLine(clsUser User, string Seperator = "#//#")
        {
            if (User == null)
                return "";

            // حماية: التأكد من عدم تمرير نص فارغ للتشفير إن كانت خوارزمية التشفير لا تدعمه
            string encryptedPassword = string.IsNullOrEmpty(User.Password)
                ? ""
                : clsUtil.EncryptText(User.Password);

            string UserRecord = "";
            UserRecord += User.UserID.ToString() + Seperator;
            UserRecord += User.PersonID.ToString() + Seperator;
            UserRecord += User.UserName + Seperator;
            UserRecord += encryptedPassword + Seperator;
            UserRecord += Convert.ToString(User.IsActive);

            return UserRecord;
        }
    }
}
