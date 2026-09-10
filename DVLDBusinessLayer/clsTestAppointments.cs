using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsTestAppointments
    {

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

        public clsTestAppointments()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;
        }

        private clsTestAppointments(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID,
            DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {
            this.TestAppointmentID = testAppointmentID;
            this.TestTypeID = testTypeID;
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.AppointmentDate = appointmentDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            this.IsLocked = isLocked;
            this.RetakeTestApplicationID = retakeTestApplicationID;
            Mode = enMode.Update;
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentsData.GetAllTestAppointments();
        }
        public static DataTable GetTestAppointmentByIDAndTestType(int ID, int testTypeID) 
        {
            return clsTestAppointmentsData.GetAllTestAppointmentsByIDAndTestTypeID(ID, testTypeID);
        }
        public static DataTable GetTestAppointmentsByID(int ID)
        {
            return clsTestAppointmentsData.GetAllTestAppointmentsByID(ID);
        }
        public static clsTestAppointments Find(int testAppointmentID)
        {
            int testTypeID = -1, localDrivingLicenseApplicationID = -1, createdByUserID = -1, retakeTestApplicationID = -1;
            DateTime appointmentDate = DateTime.Now;
            decimal paidFees = 0;
            bool isLocked = false;

            if (clsTestAppointmentsData.GetTestAppointmentInfoByID(testAppointmentID, ref testTypeID, ref localDrivingLicenseApplicationID,
                ref appointmentDate, ref paidFees, ref createdByUserID, ref isLocked, ref retakeTestApplicationID))
            {
                return new clsTestAppointments(testAppointmentID, testTypeID, localDrivingLicenseApplicationID, appointmentDate, paidFees, createdByUserID, isLocked, retakeTestApplicationID);
            }
            return null;
        }
        private bool AddNewTestApplication()
        {
            this.TestAppointmentID = clsTestAppointmentsData.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                       this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
            return (this.TestAppointmentID != -1);
        }

        private bool Update()
        {
            return clsTestAppointmentsData.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                        this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewTestApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return Update();
            }
            return false;
        }

        public bool Delete()
        {
            return clsTestAppointmentsData.DeleteTestAppointment(this.TestAppointmentID);
        }

        public  int getCountPassedTest()
        {
            return clsTestAppointmentsData.GetPassedTestByLDLAppID(this.LocalDrivingLicenseApplicationID);
        }
        public static int getCountPassedTest(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentsData.GetPassedTestByLDLAppID(LocalDrivingLicenseApplicationID);
        }

        public static int getCountFailedTest(int LocalDrivingLicenseApplicationID , int TypeID)
        {
            return clsTestAppointmentsData.GetFailedTestByLDLAppID(LocalDrivingLicenseApplicationID , TypeID);
        }
        public static bool IsExist(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentsData.IsExist(LocalDrivingLicenseApplicationID);
        }

        public bool LookTest()
        {
            return clsTestAppointmentsData.ChangeISLook(TestAppointmentID);
        }
    }
}
