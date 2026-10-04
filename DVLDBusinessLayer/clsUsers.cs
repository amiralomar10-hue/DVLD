using System;
using System.Data;
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
        public string Password { get; set; } // يحوي دائماً الـ Hash (SHA-256) عند التعامل مع الداتا بيز
        public bool IsActive { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            Mode = enMode.AddNew;
        }

        private clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            this.UserID = userID;
            this.PersonID = personID;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = isActive;
            Mode = enMode.Update;
        }

        // =========================================================================
        // 1. دوال تحويل الكائن لسطر نصي وبالعكس (تستعمل لخيار "تذكرني" بالـ Registry)
        // =========================================================================

        public static string _ConverUserObjectToLine(clsUser user, string separator = "#//#")
        {
            if (user == null) return "";
            return $"{user.UserName}{separator}{user.Password}";
        }

        public static clsUser _ConvertLinetoUserObject(string line, string separator = "#//#")
        {
            if (string.IsNullOrEmpty(line)) return null;

            string[] result = line.Split(new string[] { separator }, StringSplitOptions.None);

            if (result.Length >= 2)
            {
                clsUser user = new clsUser();
                user.UserName = result[0];
                user.Password = result[1]; // كلمة السر الصريحة المفرغة من الـ Registry
                return user;
            }

            return null;
        }

        // =========================================================================
        // 2. دوال الجلب والتحقق من قاعدة البيانات
        // =========================================================================

        // تسجيل الدخول: يستقبل اسم المستخدم والـ Hash المشفّر لمطابقتهم في SQL Server
        public static clsUser GetUserInfoByUserNameAndPassword(string userName, string hashedPassword)
        {
            int userID = -1, personID = -1;
            bool isActive = false;

            if (clsUserData.GetUserInfoByUserNameAndPassword(userName, hashedPassword, ref userID, ref personID , ref isActive))
            {
                return new clsUser(userID, personID, userName, hashedPassword, isActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser GetUserInfoByUserID(int userID)
        {
            int personID = -1;
            string userName = "", password = "";
            bool isActive = false;

            if (clsUserData.GetUserInfoByUserID(userID, ref personID, ref userName, ref password, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);
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

   

        public static bool IsUserExistForPersonID(int personID)
        {
            return clsUserData.IsUserExistForPersonID(personID);
        }

        // =========================================================================
        // 3. دوال الحفظ والتعديل
        // =========================================================================
        private bool _AddNewUser()
        {
            // يُفترض أن this.Password قد تم تحويله إلى Hash في الواجهة قبل الاستدعاء
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
                    return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static DataTable GetAllUsersIsActive()
        {
            return clsUserData.GetAllUsersIsActive();
        }
        public static DataTable GetUsersIsNotActive()
        {

            return clsUserData.GetAllUsersIsNotActive();
        }
    }
}