using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer
{
    public class clsApplicationType
    {

        public clsApplicationType() 
        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = string.Empty;
            this.ApplicationFees = -1;
        }

        public clsApplicationType
            (int ApplicationTypeID, string ApplicationTitle, double ApplicationTypeFees)
        { 
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTitle;
            this.ApplicationFees = ApplicationTypeFees;

        }

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public double ApplicationFees { get; set; }


        private bool UpdateApplicationType()
        {
            return clsApplicationTypes.UpdateApplicationTypeByID(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }
        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypes.GetAllApplicationTypes();
        }


        public static clsApplicationType Find(int ApplicationTypeID)
        {
            string ApplicationTitle = string.Empty;
            double ApplicationTypeFees = -1;

            if (clsApplicationTypes.FindApplicationTypeByID(ApplicationTypeID, ref ApplicationTitle, ref ApplicationTypeFees))
                return new clsApplicationType(ApplicationTypeID, ApplicationTitle, ApplicationTypeFees);

            return null;
        }



        public bool Save()
        {
            return UpdateApplicationType();
        }


    }
}
