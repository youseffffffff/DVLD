using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DVLD_Data_Access_Layer
{
    public class clsLicenses
    {

        public static DataTable GetAllLicenses()
        {
            DataTable Licenses = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"SELECT * From Licenses";



            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    Licenses.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                Licenses = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            Licenses.TableName = "Licenses";    

            return Licenses;
        }


        public static bool FindLicenseByLicenseID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref double PaidFees, ref bool IsActive, ref int IssueReason, ref int CreatedByUserID)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From Licenses
Where Licenses.LicenseID = @LicenseID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClassID = (int)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    Notes = Reader["Notes"].ToString();
                    PaidFees = Convert.ToDouble(Reader["PaidFees"]);
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = Convert.ToInt32(Reader["IssueReason"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);


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

        public static bool FindLicenseByApplicationID(int ApplicationID, ref int LicenseID, ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref double PaidFees, ref bool IsActive, ref int IssueReason, ref int CreatedByUserID)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From Licenses
Where Licenses.ApplicationID = @ApplicationID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    LicenseID = (int)Reader["LicenseID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClassID = (int)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    Notes = Reader["Notes"].ToString();
                    PaidFees = Convert.ToDouble(Reader["PaidFees"]);
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = Convert.ToInt32(Reader["IssueReason"]);
                    CreatedByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);


                    IsFill = true;
                }

                else
                {
                    IsFill = false;
                }
            }
            catch (Exception ex)
            {
                clsLogTheExError.LogError(ex.Message);

                IsFill = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFill;


        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"SELECT        Licenses.LicenseID
                            FROM Licenses INNER JOIN
                                                     Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE  
                             
                             Licenses.LicenseClass = @LicenseClass 
                              AND Drivers.PersonID = @PersonID
                              And IsActive=1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return LicenseID;
        }
        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, double PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {

            int LicenseID = -1;



            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
                @"Insert Into Licenses " +
                "Values (@ApplicationID, @DriverID, @LicenseClassID, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID) " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
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

            return LicenseID;
        }


        public static bool UpdateLicenseByID(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, double PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update Licenses  
                            set ApplicationID = @ApplicationID, 
                                DriverID = @DriverID, 
                                LicenseClass = @LicenseClassID, 
                                IssueDate = @IssueDate, 
                                ExpirationDate = @ExpirationDate, 
                                Notes = @Notes,
                                PaidFees = @PaidFees,
                                IsActive = @IsActive,
                                IssueReason = @IssueReason,
                                CreatedByUserID = @CreatedByUserID

                                
                                Where Licenses.LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
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


        public static bool DeleteLicenseByID(int LicenseID)
        {



            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
Delete From Licenses
Where Licenses.LicenseID = @LicenseID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);


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
    }
}
