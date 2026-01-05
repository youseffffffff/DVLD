using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer
{
    public class clsDriver
    {

        public clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            Mode = enMode.Update;
        }
        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;



        public int DriverID { get; set; }
        public int PersonID { get; set; }            
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }



        public static DataTable GetAllDrivers()
        {
            return clsDrivers.GetAllDrivers();
        }

        public static DataTable GetAllDriversOrderByColumn(string textLike, string Column)
        {
            return clsDrivers.GetAllDriversOrderByColumn(textLike, Column);
        }

        public static DataTable GetInternationalLicenseHistory(int PersonID)
        {
            return clsDrivers.GetInternationalLicenseHistory(PersonID);
        }
        public static DataTable GetLocalLicenseHistory(int PersonID)
        {
            return clsDrivers.GetLocalLicenseHistory(PersonID);
        }
        public static clsDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1;
            DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = -1;

            if (clsDrivers.FindDriverByID
                (DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);


            return null;
        }

        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1;
            DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = -1;

            if (clsDrivers.FindDriverByPersonID
                (PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);


            return null;
        }

        private bool AddNewDriver()
        {
            this.DriverID = clsDrivers.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return this.DriverID != -1;
        }
        private bool UpdateDriver()
        {
            return clsDrivers.UpdateDriverByID(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewDriver())
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
                    return UpdateDriver();

                    break;

            }
            return false;

        }


        public static bool DeleteDriverByID(int DriverID)
        {
            return clsDrivers.DeleteDriverByID(DriverID);
        }


        public static bool IsPersonDriver(int PersonID)
        {
            return clsDrivers.IsPersonDriver(PersonID);
        }



    }
}
