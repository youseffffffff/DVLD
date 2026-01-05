using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;


namespace DVLD_Business_Layer
{
    public class clsDetainedLicense
    {




        public clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, double FineFees, int CreateByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreateByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            Mode = enMode.Update;
        }
        public clsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            Mode = enMode.AddNew;
        }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;



        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public clsLicense License
        {
            get
            {
                return clsLicense.FindByLicenseID(LicenseID);
            }
        }
        public DateTime DetainDate { get; set; }
        public double FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        public clsApplication App
        {
            get
            {
                return clsApplication.Find(ReleaseApplicationID);
            }
        }



        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenses.GetAllDetainedLicenses();
        }

        public static DataTable GetAllDetainedLicensesByColumn(string TaxtLike, string Column)
        {
            return clsDetainedLicenses.GetAllDetainedLicensesOrderByColumn(TaxtLike, Column);

        }

        public static clsDetainedLicense FindByDetainID(int DetainID)
        {
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            double FineFees = -1;
            int CreateByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicenses.FindDetainedLicenseByDetaineID
                (DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreateByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreateByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);


            return null;
        }

        public static clsDetainedLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            double FineFees = -1;
            int CreateByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicenses.FindDetainedLicenseByLicenseID
                (LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref CreateByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreateByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);


            return null;
        }


        private bool AddNewDetainedLicense()
        {

            this.DetainID = clsDetainedLicenses.AddNewDetainedLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
            return DetainID != -1;
        }
        private bool UpdateDetainedLicense()
        {
            if (App != null)
            {
                App.ApplicationStatus = 3;
                App.Save();
            }
            return clsDetainedLicenses.UpdateDetainedLicenseByID(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewDetainedLicense())
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
                    return UpdateDetainedLicense();

                    break;

            }
            return false;

        }


        public static bool DeleteDetainedLicenseByID(int DetainedLicenseID)
        {
            return clsDetainedLicenses.DeleteDetainedLicenseByID(DetainedLicenseID);
        }

        public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetainedLicenses.ReleaseDetainedLicense(this.DetainID,
                   ReleasedByUserID, ReleaseApplicationID);
        }


    }
}
