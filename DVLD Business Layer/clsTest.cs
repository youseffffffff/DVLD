using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business_Layer;
using DVLD_Data_Access_Layer;


namespace DVLD_Business_Layer
{
    public class clsTest : clsTestAppointment
    {

        public clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            clsTestAppointment TestAppointment = clsTestAppointment.Find(TestAppointmentID);


       
                this.TestAppointmentID = TestAppointment.TestAppointmentID;
                this.TestType = TestAppointment.TestType;
                this.LocalApp = TestAppointment.LocalApp;
                this.AppointmentDate = TestAppointment.AppointmentDate;
                this.PaidFees = TestAppointment.PaidFees;
                this.CreatedByUserID = TestAppointment.CreatedByUserID;
                this.IsLocked = TestAppointment.IsLocked;


                Mode = enMode.Update;
        }
        public clsTest()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = string.Empty;
            this.CreatedByUserID = -1;

            this.TestAppointmentID = -1;
            this.TestType = null;
            this.LocalApp = null;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;


            Mode = enMode.AddNew;
        }

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;



        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }


        public static DataTable GetAllTests()
        {
            return clsTests.GetAllTests();
        }


        public static clsTest Find(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = string.Empty;
            int CreatedByUserID = -1;

            if (clsTests.FindTestByID
                (TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }

            return null;
        }



        private bool AddNewTest()
        {
            this.TestID = clsTests.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return this.TestID != -1;
        }
        private bool UpdateTest()
        {
            return clsTests.UpdateTestByID(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewTest())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case enMode.Update:
                    return UpdateTest();

                    break;

            }
            return false;

        }


        public static bool DeleteTestByID(int TestID)
        {
            return clsTests.DeleteTestByID(TestID);
        }




    }
}
