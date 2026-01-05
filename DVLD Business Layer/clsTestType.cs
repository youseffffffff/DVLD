using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer
{
    public class clsTestType
    {

        public clsTestType()
        {
            this.TestTypeID = -1;
            this.TestTypeTitle = string.Empty;
            this.TestDescription = string.Empty;
            this.TestFees = -1;
        }

        public clsTestType
            (int TestTypeID, string TestTypeTitle, string TestDescription, double TestFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestDescription = TestDescription;
            this.TestFees = TestFees;
        }
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        public enTestType enTestTypeID { get; set; }

        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestDescription { get; set; }
        public double TestFees { get; set; }


        private bool UpdateTestType()
        {
            return clsTestTypes.UpdateTestTypeByID(this.TestTypeID, this.TestTypeTitle, this.TestDescription, this.TestFees);
        }
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypes.GetAllTestTypes();
        }

        public static clsTestType Find(int TestTypeID)
        {
            string TestTypeTitle = string.Empty;
            string TestDescription = string.Empty;
            double TestFees = -1;

            if (clsTestTypes.FindTestTypeByID(TestTypeID, ref TestTypeTitle, ref TestDescription, ref TestFees))
                return new clsTestType(TestTypeID, TestTypeTitle, TestDescription, TestFees);
        

            return null;
        }

        public bool Save()
        {
            return UpdateTestType();
        }

    }
}
