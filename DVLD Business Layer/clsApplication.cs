using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer
{
    public class clsApplication
    {

  

        public clsApplication(int AppID, int PersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, double PaidFees, int CreateByUserID)
        {
            this.AppID = AppID;
            this.PersonID = PersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreateByUserID;

            Mode = enMode.Update;
        }
        public clsApplication()
        {
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

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };


        public int AppID { get; set; }
        public int PersonID { get; set; }

        public clsPerson Person
        {
            get
            {
                return clsPerson.Find(PersonID);
            }
        }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }

        public clsApplicationType ApplicationType
        {
            get
            {
                return clsApplicationType.Find(ApplicationTypeID);
            }
            set
            {
                this.ApplicationType = value;
            }
        }
        public int ApplicationStatus { get; set; }

        public string ApplicationStatusAsString
        {
            get
            {
               
                switch (ApplicationStatus)
                {
                    case 1:
                        return "New";
                        break;
                        
                    case 2:
                        return "Cancelled";
                        break;


                    case 3:
                        return "Complete";
                        break;        

                }
                return string.Empty;

            }
            set
            {

            }
        }
        public DateTime LastStatusDate { get; set; }
        public double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }



        public static DataTable GetAllApplications()
        {
            return clsApplications.GetAllApplications();
        }


        public static clsApplication Find(int AppID)
        {
            int PersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            int ApplicationStatus = -1;
            DateTime LastStatusDate = DateTime.Now;
            double PaidFees = -1;
            int CreateByUserID = -1;

            if (clsApplications.FindApplicationByID
                (AppID,ref PersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreateByUserID))
                return new clsApplication(AppID, PersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreateByUserID);


            return null;
        }

  

        private bool AddNewApplication()
        {

            this.AppID = clsApplications.AddNewApplication(PersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            return AppID != -1;
        }
        private bool UpdateApplication()
        {
            return clsApplications.UpdateApplicationByID(AppID, PersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
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
            return clsApplications.DeleteApplicationByID(AppID);
        }




    }
}
