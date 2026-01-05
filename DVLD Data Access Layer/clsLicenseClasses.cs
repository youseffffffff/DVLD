using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Access_Layer
{
    public class clsLicenseClasses
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable LicenseClasses = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"SELECT * From LicenseClasses";



            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    LicenseClasses.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                LicenseClasses = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            LicenseClasses.TableName = "LicenseClasses";    
            return LicenseClasses;
        }


        public static bool FindLicenseClassByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref double MinimumAllowedAge, ref double DefaultValiDityLength, ref double ClassFees)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From LicenseClasses
Where LicenseClasses.LicenseClassID = @LicenseClassID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    ClassName = (string)Reader["ClassName"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToDouble(Reader["MinimumAllowedAge"]);
                    DefaultValiDityLength = Convert.ToDouble(Reader["DefaultValiDityLength"]);
                    ClassFees = Convert.ToDouble(Reader["ClassFees"]);


                    IsFill = true;
                }

                else
                {
                    IsFill = false;
                }
            }
            catch (Exception ex)
            {
                IsFill = false;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFill;


        }


        public static bool FindLicenseClassByClassName(string ClassName, ref int LicenseClassID, ref string ClassDescription, ref double MinimumAllowedAge, ref double DefaultValiDityLength, ref double ClassFees)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From LicenseClasses
Where LicenseClasses.ClassName = @ClassName";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@ClassName", ClassName);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    LicenseClassID = (int)Reader["LicenseClassID"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToDouble(Reader["MinimumAllowedAge"]);
                    DefaultValiDityLength = Convert.ToDouble(Reader["DefaultValiDityLength"]);
                    ClassFees = Convert.ToDouble(Reader["ClassFees"]);


                    IsFill = true;
                }

                else
                {
                    IsFill = false;
                }
            }
            catch (Exception ex)
            {
                IsFill = false;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFill;


        }

    }
}
