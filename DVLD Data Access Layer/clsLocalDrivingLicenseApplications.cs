using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Security.Policy;

namespace DVLD_Data_Access_Layer
{
    public class clsLocalDrivingLicenseApplications 
    {
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable LocalDrivingLicenseApplications = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"


SELECT 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AS [L.D.LAppID], 
    LicenseClasses.ClassName AS [Driving Class], 
    People.NationalNo,
    (People.FirstName + ' ' +
    People.SecondName + ' '+
    People.ThirdName + ' '+ 
    People.LastName) AS [FULL Name], 
    Applications.ApplicationDate,

    (SELECT COUNT(DISTINCT TestAppointments.TestAppointmentID)
FROM TestAppointments 
INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID  
AND Tests.TestResult = 1) AS [Passed Tests], 

  CASE WHEN Applications.ApplicationStatus = 1 THEN 'New'
  WHEN Applications.ApplicationStatus = 2 THEN 'Canceled' 
  WHEN Applications.ApplicationStatus = 3 THEN 'Completed' END AS Status
FROM LocalDrivingLicenseApplications 
LEFT JOIN Applications 
    ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID 
LEFT JOIN LicenseClasses 
    ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID 
LEFT JOIN People 
    ON Applications.ApplicationPersonID = People.PersonID 
LEFT JOIN TestAppointments 
    ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
LEFT JOIN Tests 
    ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
GROUP BY 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
    LicenseClasses.ClassName,
    People.NationalNo,
    (People.FirstName + ' ' +
    People.SecondName + ' '+
    People.ThirdName + ' '+ 
    People.LastName),
    Applications.ApplicationDate,
    Applications.ApplicationStatus


";



            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    LocalDrivingLicenseApplications.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                LocalDrivingLicenseApplications = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            LocalDrivingLicenseApplications.TableName = "LocalDrivingLicenseApplications";
            return LocalDrivingLicenseApplications;
        }

        public static DataTable GetAllLocalDrivingLicenseApplicationsOrderByColumn(string TaxtLike, string Column)
        {
            DataTable LocalDrivingLicenseApplications = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
$@"


SELECT 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AS [L.D.LAppID], 
    LicenseClasses.ClassName AS [Driving Class], 
    People.NationalNo,
    (People.FirstName + ' ' +
    People.SecondName + ' '+
    People.ThirdName + ' '+ 
    People.LastName) AS [FULL Name], 
    Applications.ApplicationDate,
    (SELECT COUNT(DISTINCT TestAppointments.TestAppointmentID)
FROM TestAppointments 
INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID  
AND Tests.TestResult = 1) AS [Passed Tests], 
  CASE WHEN Applications.ApplicationStatus = 1 THEN 'New'
  WHEN Applications.ApplicationStatus = 2 THEN 'Canceled' 
  WHEN Applications.ApplicationStatus = 3 THEN 'Completed' END AS Status
FROM LocalDrivingLicenseApplications 
LEFT JOIN Applications 
    ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID 
LEFT JOIN LicenseClasses 
    ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID 
LEFT JOIN People 
    ON Applications.ApplicationPersonID = People.PersonID 
LEFT JOIN TestAppointments 
    ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
LEFT JOIN Tests 
    ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
GROUP BY 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
    LicenseClasses.ClassName,
    People.NationalNo,
    (People.FirstName + ' ' +
    People.SecondName + ' '+
    People.ThirdName + ' '+ 
    People.LastName),
    Applications.ApplicationDate,
    Applications.ApplicationStatus

		 Having {Column} Like @TaxtLike ";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@TaxtLike", TaxtLike + "%");


            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    LocalDrivingLicenseApplications.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                LocalDrivingLicenseApplications = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            LocalDrivingLicenseApplications.TableName = "LocalDrivingLicenseApplications";

            return LocalDrivingLicenseApplications;
        }

        public static bool FineLocalDrivingLicenseApplicationByID(int LocalAppID, ref int AppID, ref int LicenseClassID)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From LocalDrivingLicenseApplications
Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalAppID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    AppID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
                


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


        public static bool IsHasAnotherSameActiveApplication(string LicenseClass, string NationalNo)
        {




            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"



SELECT 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AS [L.D.LAppID], 
    LicenseClasses.ClassName AS [Driving Class], 
    People.NationalNo,
    (People.FirstName + ' ' +
    People.SecondName + ' '+
    People.ThirdName + ' '+ 
    People.LastName) AS [FULL Name], 
    Applications.ApplicationDate,
    (SELECT COUNT(DISTINCT TestAppointments.TestAppointmentID)
FROM TestAppointments 
INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID  
AND Tests.TestResult = 1) AS [Passed Tests], 
  CASE WHEN Applications.ApplicationStatus = 1 THEN 'New'
  WHEN Applications.ApplicationStatus = 2 THEN 'Canceled' 
  WHEN Applications.ApplicationStatus = 3 THEN 'Completed' END AS Status
FROM LocalDrivingLicenseApplications 
LEFT JOIN Applications 
    ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID 
LEFT JOIN LicenseClasses 
    ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID 
LEFT JOIN People 
    ON Applications.ApplicationPersonID = People.PersonID 
LEFT JOIN TestAppointments 
    ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
LEFT JOIN Tests 
    ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
GROUP BY 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
    LicenseClasses.ClassName,
    People.NationalNo,
    (People.FirstName + ' ' +
    People.SecondName + ' '+
    People.ThirdName + ' '+ 
    People.LastName),
    Applications.ApplicationDate,
    Applications.ApplicationStatus


Having LicenseClasses.ClassName = @LicenseClass And People.NationalNo = @NationalNo And Applications.ApplicationStatus <> 2";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);


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

        public static int AddNewLocalApplication(int AppID, int LicenseClassID)
        {

            int LocalAppID = -1;



            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
                @"Insert Into LocalDrivingLicenseApplications " +
                "Values (@AppID, @LicenseClassID) " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@AppID", AppID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
        

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LocalAppID = insertedID;
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

            return LocalAppID;
        }


        public static bool UpdateLocalApplicationByID(int LocalAppID, int AppID, int LicenseClassID)
        { 
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update LocalDrivingLicenseApplications   
                            set LocalDrivingLicenseApplications.ApplicationID = @AppID, 
                                LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
  
                                Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalAppID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
            Command.Parameters.AddWithValue("@AppID", AppID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


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


        public static bool DeleteLocalApplicationByID(int LocalAppID)
        {



            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
Delete From LocalDrivingLicenseApplications
Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalAppID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);


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

        public static int GetPassedTestsByLocalAppID(int LocalAppID)
        {

            int PassedTests = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"

select 

(
    (SELECT COUNT(DISTINCT TestAppointments.TestAppointmentID)
FROM TestAppointments 
INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID  
AND Tests.TestResult = 1) 
)
AS [Passed Tests]

From LocalDrivingLicenseApplications

Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalAppID

";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LocalAppID", LocalAppID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    PassedTests = Convert.ToInt32(Reader["Passed Tests"]);


                }

                else
                {
                    PassedTests = -1;
                }
            }
            catch (Exception ex)
            {
                PassedTests = -1;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return PassedTests;

        }


        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
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

            return IsFound;

        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {


            bool Result = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                {
                    Result = returnedResult;
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

            return Result;

        }
        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {

            bool Result = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked=0
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    Result = true;
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

            return Result;

        }

    }
}
