using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Access_Layer
{
    public class clsDrivers
    {
        public static DataTable GetAllDrivers()
        {
            DataTable Drivers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"SELECT * From Drivers";



            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    Drivers.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                Drivers = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            Drivers.TableName = "Drivers";

            return Drivers;

        }

        public static DataTable GetAllDriversOrderByColumn(string textLike, string Column)
        {
            DataTable Drivers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query = @"Select * From Drivers " +
                   $"Where {Column} Like @textLike ";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@textLike", textLike + "%");

            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    Drivers.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                Drivers = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            Drivers.TableName = "Drivers";

            return Drivers;
        }
        public static DataTable GetInternationalLicenseHistory(int PersonID)
        {
            DataTable LicenseHistory = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"
Select InternationalLicenses.InternationalLicenseID, InternationalLicenses.ApplicationID, LocalLicenses.ClassName,
InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive
From
(
SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive, People.PersonID
FROM  People INNER JOIN
         Applications ON People.PersonID = Applications.ApplicationPersonID INNER JOIN
         Licenses ON Applications.ApplicationID = Licenses.ApplicationID INNER JOIN
         LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
		 Where People.PersonID = @PersonID
)
LocalLicenses Inner Join InternationalLicenses On InternationalLicenses.IssuedUsingLocalLicenseID = LocalLicenses.LicenseID
		 

";



            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    LicenseHistory.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                LicenseHistory = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            LicenseHistory.TableName = "LicenseHistory";

            return LicenseHistory;
        }

        public static DataTable GetLocalLicenseHistory(int PersonID)
        {
            DataTable LicenseHistory = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"

SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
FROM  People INNER JOIN
         Applications ON People.PersonID = Applications.ApplicationPersonID INNER JOIN
         Licenses ON Applications.ApplicationID = Licenses.ApplicationID INNER JOIN
         LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
		 Where People.PersonID = @PersonID
";



            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    LicenseHistory.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                LicenseHistory = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            LicenseHistory.TableName = "LicenseHistory";
            return LicenseHistory;
        }

        public static bool FindDriverByID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From Drivers
Where Drivers.DriverID = @DriverID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                    CreatedDate = (DateTime)Reader["CreatedDate"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];


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

        public static bool FindDriverByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From Drivers
Where Drivers.PersonID = @PersonID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    DriverID = Convert.ToInt32(Reader["DriverID"]);
                    CreatedDate = (DateTime)Reader["CreatedDate"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];


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

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int DriverID = -1;



            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
                @"Insert Into Drivers " +
                "Values (@PersonID, @CreatedByUserID, @CreatedDate) " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DriverID = insertedID;
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

            return DriverID;
        }


        public static bool UpdateDriverByID(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update Drivers  
                            set PersonID = @PersonID, 
                                CreatedByUserID = @CreatedByUserID, 
                                CreatedDate = @CreatedDate, 
        

                                
                                Where Drivers.DriverID = @DriverID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);    
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                RowsEffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (RowsEffected > 0);
        }


        public static bool DeleteDriverByID(int DriverID)
        {



            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
Delete From Drivers
Where Drivers.DriverID = @DriverID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();
                RowsEffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return RowsEffected > 0;


        }

        public static bool IsPersonDriver(int PersonID)
        {


            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From Drivers
Where Drivers.PersonID = @PersonID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

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
