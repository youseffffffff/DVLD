using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Access_Layer
{
    public class clsTestAppointments
    {
        public static DataTable GetAllTestAppointments()
        {
            DataTable TestAppointments = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"SELECT TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, TestAppointments.PaidFees, TestAppointments.IsLocked From TestAppointments";



            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    TestAppointments.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                TestAppointments = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            TestAppointments.TableName = "TestAppointments";
            return TestAppointments;
        }

        public static DataTable GetAllTestsAppointmentsByLocalAppID(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            DataTable TestAppointments = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"

Select TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, TestAppointments.PaidFees, TestAppointments.IsLocked From TestAppointments 
Where TestAppointments.TestTypeID = @TestTypeID And TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;

";



            SqlCommand Command = new SqlCommand(query, connection);


            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    TestAppointments.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                TestAppointments = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            TestAppointments.TableName = "TestAppointments";

            return TestAppointments;
        }


        public static bool FindTestAppointmentByID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref double PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {



            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    IsLocked = (bool)reader["IsLocked"];

                    if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;


        }


        public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingKicenseApplicationID, DateTime AppointmentDate, double PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {

            int TestAppointmentID = -1;



            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
                @"Insert Into TestAppointments 
                Values (@TestTypeID, @LocalDrivingKicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID) 
                SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingKicenseApplicationID", LocalDrivingKicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID == -1)
            {
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            }


            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
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

            return TestAppointmentID;
        }


        public static bool UpdateTestAppointmentByID(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, double PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update TestAppointments  
                            set TestTypeID = @TestTypeID, 
                                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID, 
                                AppointmentDate = @AppointmentDate, 
                                PaidFees = @PaidFees, 
                                CreatedByUserID = @CreatedByUserID, 
                                IsLocked = @IsLocked,
                                RetakeTestApplicationID = @RetakeTestApplicationID

                                
                                Where TestAppointments.TestAppointmentID = @TestAppointmentID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == -1)
            {
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            }
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


        public static bool DeleteTestAppointmentByID(int TestAppointmentID)
        {



            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
Delete From TestAppointments
Where TestAppointments.TestAppointmentID = @TestAppointmentID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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
