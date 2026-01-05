using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;


namespace DVLD_Business_Layer
{
    public class clsTestAppointment 
    {



        public clsTestAppointment()

        {
            this.TestAppointmentID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;

        }

        public clsTestAppointment(int TestAppointmentID, clsTestType.enTestType TestTypeID,
           int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, double PaidFees,
           int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)

        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestType = clsTestType.Find((int)TestTypeID);
            this.LocalApp = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeTestAppInfo = clsApplication.Find(RetakeTestApplicationID);
            Mode = enMode.Update;
        }

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        
        public int TestAppointmentID { get; set; }
        public clsTestType TestType { get; set; }
        public clsLocalDrivingLicenseApplication LocalApp { get; set; }
        public DateTime AppointmentDate { get; set; }
        public double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { set; get; }
        public clsApplication RetakeTestAppInfo { set; get; }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointments.GetAllTestAppointments();
        }

        public static DataTable GetAllTestsAppointmentsByLocalAppID(int TestTypeID, int LocalAppID)
        {
            return clsTestAppointments.GetAllTestsAppointmentsByLocalAppID(TestTypeID,  LocalAppID);
        }

        public static clsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = 1; int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now; double PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (clsTestAppointments.FindTestAppointmentByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
            ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppointment(TestAppointmentID, (clsTestType.enTestType)TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }



        private bool AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointments.AddNewTestAppointment(this.TestType.TestTypeID, this.LocalApp.LocalAppID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
            return TestAppointmentID != -1;
        }
        private bool UpdateTestAppointment()
        {
            return clsTestAppointments.UpdateTestAppointmentByID(this.TestAppointmentID, this.TestType.TestTypeID, this.LocalApp.LocalAppID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewTestAppointment())
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
                    return UpdateTestAppointment();

                    break;

            }
            return false;

        }


        public static bool DeleteTestAppointmentByID(int TestAppointmentID)
        {
            return clsTestAppointments.DeleteTestAppointmentByID(TestAppointmentID);
        }

    }
}
