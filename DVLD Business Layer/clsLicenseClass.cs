using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer
{
    public class clsLicenseClass
    {



        public clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, double MinimumAllowedAge, double DefaultValiDityLength, double ClassFees)
        {

            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValiDityLength = DefaultValiDityLength;
            this.ClassFees = ClassFees;

        }


        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public double MinimumAllowedAge { get; set; }
        public double DefaultValiDityLength { get; set; }
        public double ClassFees { get; set; }






        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClasses.GetAllLicenseClasses();

        }

        public static clsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = string.Empty;
            string ClassDescription = string.Empty;
            double MinimumAllowedAge = -1;
            double DefaultValiDityLength = -1;
            double ClassFees = -1;


            if (clsLicenseClasses.FindLicenseClassByID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValiDityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValiDityLength, ClassFees);
            }

            return null;
            
        }

        public static clsLicenseClass Find(string ClassName)
        
        {
            int LicenseClassID = -1;
            string ClassDescription = string.Empty;
            double MinimumAllowedAge = -1;
            double DefaultValiDityLength = -1;
            double ClassFees = -1;


            if (clsLicenseClasses.FindLicenseClassByClassName(ClassName, ref LicenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValiDityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValiDityLength, ClassFees);
            }

            return null;

        }


    }
}
