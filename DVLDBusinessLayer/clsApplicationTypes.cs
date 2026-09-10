using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using DVLDBusinessLayer;
namespace DVLDBusinessLayer
{
    public class clsApplicationTypes
    {
        public int ApplicationTypeID { get; set; }

        public string ApplicationTypeTitle { get; set; }

        public decimal ApplicationFees { get; set; }

        public clsApplicationTypes() {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = string.Empty;
            ApplicationFees = 0;
        }

        public clsApplicationTypes(int applicationTypeID , string applicationTypesTitle , decimal applicationFess)
        {
            ApplicationTypeID = applicationTypeID;
            ApplicationTypeTitle = applicationTypesTitle;
            ApplicationFees = applicationFess;
        }

        public static DataTable GetApplicationTypes()
        {
            return ApplicationTypesData.getAllApplicationTypes();
        }


        public static clsApplicationTypes GetApplicationTypesInfoByID(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = 0;
            if (ApplicationTypesData.getApplicationTypesByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle , ApplicationFees);
            }
            else
            {
                return null;
            }
        }

        public bool UpdateApplicationType()
        {
            return ApplicationTypesData.UpdateApplicatonType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees); 
        }

        
    }
}
