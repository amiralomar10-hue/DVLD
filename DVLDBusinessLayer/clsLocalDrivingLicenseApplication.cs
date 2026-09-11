using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public enum enModeLocal { AddNew = 0, Update = 1 }
        public enModeLocal mode { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            base.ApplicationID = -1;
            LicenseClassID = -1;
            mode = enModeLocal.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID, int applicationID, int licenseClassID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeID, int applicationStatus, DateTime lastStatusDate,
            decimal paidFees, int createdByUserID) : base(applicationID, applicantPersonID, applicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID)
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.LicenseClassID = licenseClassID;
            this.mode = enModeLocal.Update;
        }

        public static DataTable GetListLocalDrivingLicenseApplications()
        {
            return LocalDrivingLicenseApplicationData.ListALLLocalDrivingLicenseAppLications();
        }

        public static clsLocalDrivingLicenseApplication FindByID(int id)
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (LocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(id, ref ApplicationID, ref LicenseClassID))
            {
                clsApplication application = clsApplication.FindBaseApplication(ApplicationID);
                return new clsLocalDrivingLicenseApplication(id, ApplicationID, LicenseClassID, application.ApplicantPersonID, application.ApplicationDate, application.ApplicationTypeID, application.ApplicationStatus, application.LastStatusDate, application.PaidFees, application.CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public bool AddNewLDLApplication()
        {
            int id = LocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);
            if (id != -1)
            {
                this.LocalDrivingLicenseApplicationID = id;
                return true;
            }
            return false;
        }

        public bool Delete()
        {
            bool isLocalDeleted = LocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);
            if (!isLocalDeleted) return false;

            return base.Save();
        }

        public static bool Delete(int LocalDrivingLicenseApplicationID)
        {
            clsLocalDrivingLicenseApplication localApp = clsLocalDrivingLicenseApplication.FindByID(LocalDrivingLicenseApplicationID);
            if (localApp == null) return false;

            int baseAppID = localApp.ApplicationID;

            if (!LocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID))
                return false;

            return clsApplication.DeleteApplication(baseAppID);
        }

        public bool Update()
        {
            return LocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
        }

        public bool Save()
        {
            if (!base.Save())
            {
                return false;
            }

            switch (mode)
            {
                case enModeLocal.AddNew:
                    if (AddNewLDLApplication())
                    {
                        mode = enModeLocal.Update;
                        return true;
                    }
                    return false;
                case enModeLocal.Update:
                    return Update();
            }

            return false;
        }

        public static bool IsExistLocalDrivingLicenseApplication(int PersonID, int LicenseClassID, int Status, ref int ApplicationID)
        {
            ApplicationID = LocalDrivingLicenseApplicationData.IsExistLocalDrivingLicenseApplication(PersonID, LicenseClassID, Status);
            return (ApplicationID > 0);
        }

        public bool Cancel()
        {
            return clsApplicationDataAccess.ChanageApplicationStatusToCancel(this.ApplicationID);
        }

        public bool Complete()
        {
            return clsApplicationDataAccess.ChanageApplicationStatusToComplete(this.ApplicationID);
        }

        public static int GetActiveLocalDrivingLicenseApplicationID(int PersonID, int LicenseClassID)
        {
            return LocalDrivingLicenseApplicationData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);
        }
    }
}