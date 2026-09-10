using System.Data;
using DVLDDataAccessLayer;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTestType
    {
        public enum enMode { UpdateMode = 0 }
        public enMode Mode = enMode.UpdateMode;

        public int TestTypeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }

        public clsTestType()
        {
            this.TestTypeID = -1;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;
        }

        private clsTestType(int id, string title, string description, decimal fees)
        {
            this.TestTypeID = id;
            this.Title = title;
            this.Description = description;
            this.Fees = fees;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

        public static clsTestType Find(int id)
        {
            string title = "";
            string description = "";
            decimal fees = 0;

            if (clsTestTypeData.GetTestTypeByID(id, ref title, ref description, ref fees))
            {
                return new clsTestType(id, title, description, fees);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            return clsTestTypeData.UpdateTestType(this.TestTypeID, this.Title, this.Description, this.Fees);
        }
    }
}