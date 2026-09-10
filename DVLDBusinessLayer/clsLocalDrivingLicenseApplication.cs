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
    
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
       public enum enModeLocal
        {
            AddNew = 0 , Update = 1,
        }
        public enModeLocal mode { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }

        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;

            base.ApplicationID = -1;

            LicenseClassID = -1;

        }

        private clsLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID, int applicationID, int licenseClassID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeID, int applicationStatus, DateTime lastStatusDate,
            decimal paidFees, int createdByUserID) : base(applicationID, applicantPersonID, applicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID)
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.LicenseClassID = licenseClassID;
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
                return new clsLocalDrivingLicenseApplication(id,ApplicationID, LicenseClassID, application.ApplicantPersonID, application.ApplicationDate, application.ApplicationTypeID, application.ApplicationStatus, application.LastStatusDate, application.PaidFees, application.CreatedByUserID);
            }
            else
            {
                return null;
            }
        }


        public bool AddNewLDLApplication()
        {
            int LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);
            return (LocalDrivingLicenseApplicationID != -1);
        }


        public bool Delete()
        {

            return LocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
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

            else
            {
                switch (mode)
                {
                    case enModeLocal.AddNew:
                        if (AddNewLDLApplication())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        return false;

                    case enModeLocal.Update:
                        return Update();
                }
            }
            return false;
        }

        public static bool IsExistLocalDrivingLicenseApplication(int PersonID, int LicenseClassID, int Status ,ref int ApplicationID )
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
    }
}
