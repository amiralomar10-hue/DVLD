using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    
    public class clsInternationalLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicenses()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = true;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsInternationalLicenses(int internationalLicenseID, int applicationID, int driverID,
            int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate,
            bool isActive, int createdByUserID)
        {
            this.InternationalLicenseID = internationalLicenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.IsActive = isActive;
            this.CreatedByUserID = createdByUserID;

            Mode = enMode.Update;
        }

        public static clsInternationalLicenses Find (int internationalLicenseID)
        {
            int applicationID = -1, driverID = -1, issuedUsingLocalLicenseID = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            bool isActive = false;

            if (clsInternationalLicenseData.GetInternationalLicenseInfoByID(
                internationalLicenseID, ref applicationID, ref driverID,
                ref issuedUsingLocalLicenseID, ref issueDate, ref expirationDate,
                ref isActive, ref createdByUserID))
            {
                return new clsInternationalLicenses(internationalLicenseID , applicationID , driverID , issuedUsingLocalLicenseID , issueDate, expirationDate, isActive, createdByUserID);
            }
            

            return null;
        }

        public static clsInternationalLicenses FindByLocalID( int issuedUsingLocalLicenseID)
        {
            int applicationID = -1, driverID = -1, internationalLicenseID = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            bool isActive = false;

            if (clsInternationalLicenseData.GetInternationalLicenseInfoByLocalLicenseID(issuedUsingLocalLicenseID , ref internationalLicenseID , ref applicationID , ref driverID , ref issueDate , ref expirationDate , ref isActive , ref createdByUserID))
            {
                return new clsInternationalLicenses(internationalLicenseID, applicationID, driverID, issuedUsingLocalLicenseID, issueDate, expirationDate, isActive, createdByUserID);
            }


            return null;
        }

        public static bool IsExit(int issuedUsingLocalLicenseID)
    {
        int applicationID = -1, driverID = -1, internationalLicenseID = -1, createdByUserID = -1;
        DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
        bool isActive = false;

            return (clsInternationalLicenseData.GetInternationalLicenseInfoByLocalLicenseID(issuedUsingLocalLicenseID, ref internationalLicenseID, ref applicationID, ref driverID, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID));
      }
        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(
                this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(
                this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate,
                this.IsActive, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateInternationalLicense();
            }

            return false;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public static DataTable getLicensesByPersonID(int PersonID)
        {
            return clsInternationalLicenseData.GetInternationalLicensesInfoByPersonID(PersonID);
        }
    }
}
