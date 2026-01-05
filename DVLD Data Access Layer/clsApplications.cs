using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DVLD_Data_Access_Layer
{
    public class clsApplications
    {
        public static DataTable GetAllApplications()
        {
            DataTable Applications = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"SELECT * From Applications";



            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    Applications.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                Applications = null;

                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            Applications.TableName = "Applications";
            return Applications;
        }


        public static bool FindApplicationByID(int AppID, ref int PersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime LastStatusDate, ref double PaidFees, ref int CreateByUserID)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From Applications
Where Applications.ApplicationID = @AppID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@AppID", AppID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    PersonID = Convert.ToInt32(Reader["ApplicationPersonID"]);
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationTypeID = Convert.ToInt32(Reader["ApplicationTypeID"]);
                    ApplicationStatus = Convert.ToInt32(Reader["ApplicationStatus"]);
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    PaidFees = Convert.ToDouble(Reader["PaidFees"]);
                    CreateByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);


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


        public static int AddNewApplication(int PersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, double PaidFees, int CreatedByUserID)
        {

            int AppID = -1;



            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
                @"Insert Into Applications " +
                "Values (@PersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID) " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AppID = insertedID;
                }
            }
            catch
            (Exception ex)
            {
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return AppID;
        }

        
        public static bool UpdateApplicationByID(int AppID, int PersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, double PaidFees, int CreateByUserID)
            {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update Applications  
                            set ApplicationPersonID = @PersonID, 
                                ApplicationDate = @ApplicationDate, 
                                ApplicationTypeID = @ApplicationTypeID, 
                                ApplicationStatus = @ApplicationStatus, 
                                LastStatusDate = @LastStatusDate, 
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID

                                
                                Where Applications.ApplicationID = @AppID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@AppID", AppID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreateByUserID);

            try
            {
                connection.Open();

                RowsEffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsLogTheExError.LogError(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsEffected > 0);
        }


        public static bool DeleteApplicationByID(int AppID)
        {



            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
Delete From Applications
Where Applications.ApplicationID = @AppID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@AppID", AppID);


            try
            {
                connection.Open();
                RowsEffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsLogTheExError.LogError(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return RowsEffected > 0;


        }

    }
}
