using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;


namespace DVLD_Data_Access_Layer
{
    public class clsApplicationTypes
    {


        public static DataTable GetAllApplicationTypes()
        {
            DataTable ApplicationTypes = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select * From ApplicationTypes";

            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    ApplicationTypes.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                ApplicationTypes = null;

                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            ApplicationTypes.TableName = "ApplicationTypes";

            return ApplicationTypes;
        }


        public static bool FindApplicationTypeByID(int ApplicationTypeID, ref string ApplicationTitle, ref double ApplicationFees)
        {
            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select * From ApplicationTypes Where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationTitle = Convert.ToString(Reader["ApplicationTypeTitle"]);
                    ApplicationFees = Convert.ToDouble(Reader["ApplicationFees"]);

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

        public static bool UpdateApplicationTypeByID(int ApplicationTypeID, string ApplicationTitle, double ApplicationFees)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update ApplicationTypes "  +
                         "set ApplicationTypeTitle = @ApplicationTypeTitle, ApplicationFees = @ApplicationFees " + 
                         "Where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTitle);
            Command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);


            try
            {
                connection.Open();

                RowsEffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return RowsEffected > 0;

        }

    }
}
