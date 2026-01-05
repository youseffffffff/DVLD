using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;
using static System.Net.Mime.MediaTypeNames;


namespace DVLD_Business_Layer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {


        public clsLocalDrivingLicenseApplication(int LocalAppID, int AppID, int ClassLicenseID)

        {
            this.LocalAppID = LocalAppID;
            this.LicenseClassID = ClassLicenseID;


            clsApplication App = clsApplication.Find(AppID);

            this.AppID = AppID;
            
            this.PersonID = App.PersonID;
            this.ApplicationDate = App.ApplicationDate;
            this.ApplicationTypeID = App.ApplicationTypeID;
            this.ApplicationStatus = App.ApplicationStatus;
            this.LastStatusDate = App.LastStatusDate;
            this.PaidFees = App.PaidFees;
            this.CreatedByUserID = App.CreatedByUserID;


            Mode = enMode.Update;
        }
        public clsLocalDrivingLicenseApplication()
        {
            this.LocalAppID = -1;
            this.LicenseClassID = -1;


            this.AppID = -1;
            this.PersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = -1;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;



        public int LocalAppID { get; set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo 
        {
            get
            {
                return clsLicenseClass.Find(this.LicenseClassID);
            }
        
        }





        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
        }
                
        public static DataTable GetAllLocalDrivingLicenseApplicationsByColumn(string TaxtLike, string Column)
        {
            return clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplicationsOrderByColumn(TaxtLike, Column);

        }

        public static clsLocalDrivingLicenseApplication Find(int LocalAppID)
        {
            int AppID = -1;
            int ClassLicenseID = -1;

            if (clsLocalDrivingLicenseApplications.FineLocalDrivingLicenseApplicationByID
                (LocalAppID, ref AppID, ref ClassLicenseID))
                return new clsLocalDrivingLicenseApplication(LocalAppID, AppID, ClassLicenseID);
            

            return null;
        }

        public static bool IsHasAnotherSameApplication(string LicenseClass, string NationalNo)
        {
            return clsLocalDrivingLicenseApplications.IsHasAnotherSameActiveApplication(LicenseClass, NationalNo);
        }
                

        private bool AddNewApplication()
        {

            this.AppID = clsApplications.AddNewApplication(PersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);


            this.LocalAppID = clsLocalDrivingLicenseApplications.AddNewLocalApplication(this.AppID, this.LicenseClassID);


            return AppID != -1;
        }
        private bool UpdateApplication()
        {
            return
            (
            clsApplications.UpdateApplicationByID(this.AppID, this.PersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID)

            &&

            clsLocalDrivingLicenseApplications.UpdateLocalApplicationByID(this.LocalAppID, this.AppID, this.LicenseClassID)
            );
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewApplication())
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
                    return UpdateApplication();

                    break;

            }
            return false;

        }


        public static bool DeleteApplicationByID(int AppID)
        {
            return clsLocalDrivingLicenseApplications.DeleteLocalApplicationByID(AppID);
        }

        public static int GetPassedTestsByLocalAppID(int LocalAppID)
        {
            return clsLocalDrivingLicenseApplications.GetPassedTestsByLocalAppID(LocalAppID);
        }
        public bool IsPassedAllTests()
        {
            return GetPassedTestsByLocalAppID(LocalAppID) == 3;
        }
        public bool DoesAttendTestType(int TestTypeID)
        {
            return clsLocalDrivingLicenseApplications.DoesAttendTestType(this.LocalAppID, TestTypeID);
        }
        public bool DoesPassTestType(int TestTypeID)

        {
            return clsLocalDrivingLicenseApplications.DoesPassTestType(this.LocalAppID, TestTypeID);
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {

            return clsLocalDrivingLicenseApplications.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

                
        public bool SetComplete()
        {
            clsApplication app = clsApplication.Find(AppID);
            app.ApplicationStatus = (int)clsApplication.enApplicationStatus.Completed;

            return app.Save();
        }
        public int IssueLicenseForTheFirtTime(string Notes, int CreatedByUserID)
        {
            int DriverID = -1;

            clsDriver Driver = clsDriver.FindByPersonID(this.PersonID);

            if (Driver == null)
            {
                //we check if the driver already there for this person.
                Driver = new clsDriver();

                Driver.PersonID = this.PersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID = Driver.DriverID;
            }
            //now we diver is there, so we add new licesnse

            clsLicense License = new clsLicense();
            License.ApplicationID = this.AppID;
            License.DriverID = DriverID;
            License.LicenseClassID = this.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears((int)this.LicenseClassInfo.DefaultValiDityLength);
            License.Notes = Notes;
            License.PaidFees = this.LicenseClassInfo.ClassFees;
            License.IsActive = true;
            License.IssueReason = clsLicense.enIssueReason.FirstTime;
            License.CreatedByUserID = CreatedByUserID;

            if (License.Save())
            {
                //now we should set the application status to complete.
                this.SetComplete();

                return License.LicenseID;
            }

            else
                return -1;
        }

        public int GetActiveLicenseID()
        {//this will get the license id that belongs to this application
            return clsLicense.GetActiveLicenseIDByPersonID(this.PersonID, this.LicenseClassID);
        }

    }
}
