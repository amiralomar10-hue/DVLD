using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsTests
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTests()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsTests(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            this.TestID = testID;
            this.TestAppointmentID = testAppointmentID;
            this.TestResult = testResult;
            this.Notes = notes;
            this.CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        public static clsTests Find(int testID)
        {
            int testAppointmentID = -1, createdByUserID = -1;
            bool testResult = false;
            string notes = "";

            if (clsTestData.GetTestInfoByID(testID, ref testAppointmentID, ref testResult, ref notes, ref createdByUserID))
                return new clsTests(testID, testAppointmentID, testResult, notes, createdByUserID);
            else
                return null;
        }
        public bool AddNewTest()
        {
            TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return (TestID != -1);
        }

        public bool UpdateTest()
        {
            return clsTestData.UpdateTest(TestID , TestAppointmentID , this.TestResult, this.Notes,this.CreatedByUserID);
        }

        public bool Delete()
        {
            return clsTestData.DeleteTest(TestID);  
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(AddNewTest())
                    {                
                        Mode = enMode.Update;
                            return true;
                    }
                        return false;
                case enMode.Update:
                    return UpdateTest();
            }

            return false;
        }
    }
}
