using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DVLD_Data_Access_Layer
{
    internal class clsConnectionString
    {
        //public static string ConnectionString = "Server=.;Database=DVLD;Integrated Security=true;";


        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLD"].ConnectionString;


    }
}
