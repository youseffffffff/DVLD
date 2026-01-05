using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Access_Layer
{
    public class clsDetainedLicenses
    {


        public static DataTable GetAllDetainedLicenses()
        {
            DataTable DetainedLicenses = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
@"
SELECT DetainedLicenses.DetainID,DetainedLicenses.LicenseID, DetainDate, FineFees,
case IsReleased
when 1 Then 'Yes'
else 'No' 
end as IsReleased,
ReleaseDate,
ReleaseApplicationID

From DetainedLicenses
";



            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    DetainedLicenses.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                DetainedLicenses = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            DetainedLicenses.TableName = "DetainedLicenses";
            return DetainedLicenses;
        }
        public static DataTable GetAllDetainedLicensesOrderByColumn(string TaxtLike, string Column)
        {
            DataTable DetainedLicenses = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
$@"
SELECT DetainedLicenses.DetainID,DetainedLicenses.LicenseID, DetainDate, FineFees,
case IsReleased
when 1 Then 'Yes'
else 'No' 
end as IsReleased,
ReleaseDate,
ReleaseApplicationID

From DetainedLicenses
		 Where {Column} Like @TaxtLike 
";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@TaxtLike", TaxtLike + "%");


            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    DetainedLicenses.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                DetainedLicenses = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            DetainedLicenses.TableName = "DetainedLicenses";

            return DetainedLicenses;
        }

        public static bool FindDetainedLicenseByDetaineID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref double FineFees, ref int CreateByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From DetainedLicenses
Where DetainedLicenses.DetainID = @DetainID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    LicenseID = Convert.ToInt32(Reader["LicenseID"]);
                    DetainDate = Convert.ToDateTime(Reader["DetainDate"]);
                    FineFees = Convert.ToDouble(Reader["FineFees"]);
                    CreateByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    IsReleased = Convert.ToBoolean(Reader["IsReleased"]);
                    if (IsReleased)
                    {
                        ReleaseDate = Convert.ToDateTime(Reader["ReleaseDate"]);
                        ReleasedByUserID = Convert.ToInt32(Reader["ReleasedByUserID"]);
                        ReleaseApplicationID = Convert.ToInt32(Reader["ReleaseApplicationID"]);
                    }


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

        public static bool FindDetainedLicenseByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref double FineFees, ref int CreateByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {



            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
SELECT * From DetainedLicenses
Where DetainedLicenses.LicenseID = @LicenseID
Order By DetainedLicenses.DetainID desc
";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    DetainID = Convert.ToInt32(Reader["DetainID"]);
                    DetainDate = Convert.ToDateTime(Reader["DetainDate"]);
                    FineFees = Convert.ToDouble(Reader["FineFees"]);
                    CreateByUserID = Convert.ToInt32(Reader["CreatedByUserID"]);
                    IsReleased = Convert.ToBoolean(Reader["IsReleased"]);
                    if (IsReleased)
                    {                          
                        ReleaseDate = Convert.ToDateTime(Reader["ReleaseDate"]);                          
                        ReleasedByUserID = Convert.ToInt32(Reader["ReleasedByUserID"]);                           
                        ReleaseApplicationID = Convert.ToInt32(Reader["ReleaseApplicationID"]);
                    }


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

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, double FineFees, int CreateByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {

            int DetainID = -1;



            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query;
            SqlCommand Command;

            if (IsReleased)
            {
                query =
                    @"Insert Into DetainedLicenses " +
                    "Values (@LicenseID, @DetainDate, @FineFees, @CreateByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID) " +
                    "SELECT SCOPE_IDENTITY();";
                Command = new SqlCommand(query, connection);

                Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                Command.Parameters.AddWithValue("@DetainDate", DetainDate);
                Command.Parameters.AddWithValue("@FineFees", FineFees);
                Command.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);
                Command.Parameters.AddWithValue("@IsReleased", IsReleased);
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {
                query =
    @"Insert Into DetainedLicenses " +
    "Values (@LicenseID, @DetainDate, @FineFees, @CreateByUserID, @IsReleased, NULL, NULL, NULL) " +
    "SELECT SCOPE_IDENTITY();";
                Command = new SqlCommand(query, connection);

                Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                Command.Parameters.AddWithValue("@DetainDate", DetainDate);
                Command.Parameters.AddWithValue("@FineFees", FineFees);
                Command.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);
                Command.Parameters.AddWithValue("@IsReleased", IsReleased);


            }



            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DetainID = insertedID;
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

            return DetainID;
        }

        public static bool UpdateDetainedLicenseByID(int DetainID, int LicenseID, DateTime DetainDate, double FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsEffected = 0;


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query;
            SqlCommand Command;

            if (IsReleased)
            {

                query = @"Update DetainedLicenses  
                            set LicenseID = @LicenseID, 
                                DetainDate = @DetainDate, 
                                FineFees = @FineFees, 
                                CreatedByUserID = @CreatedByUserID, 
                                IsReleased = @IsReleased, 

                                ReleaseDate = @ReleaseDate,
                                ReleasedByUserID = @ReleasedByUserID,
                                ReleaseApplicationID = @ReleaseApplicationID

                                
                                Where DetainedLicenses.DetainID = @DetainID";


                Command = new SqlCommand(query, connection);

                Command.Parameters.AddWithValue("@DetainID", DetainID);
                Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                Command.Parameters.AddWithValue("@DetainDate", DetainDate);
                Command.Parameters.AddWithValue("@FineFees", FineFees);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                Command.Parameters.AddWithValue("@IsReleased", IsReleased);
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {

                query = @"Update DetainedLicenses  
                            set LicenseID = @LicenseID, 
                                DetainDate = @DetainDate, 
                                CreatedByUserID = @CreatedByUserID, 
                                IsReleased = @IsReleased

                                
                                Where DetainedLicenses.DetainID = @DetainID";


                Command = new SqlCommand(query, connection);

                Command.Parameters.AddWithValue("@DetainID", DetainID);
                Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                Command.Parameters.AddWithValue("@DetainDate", DetainDate);
                Command.Parameters.AddWithValue("@FineFees", FineFees);
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                Command.Parameters.AddWithValue("@IsReleased", IsReleased);


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

        public static bool DeleteDetainedLicenseByID(int DetainID)
        {



            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query =
@"
Delete From DetainedLicenses
Where DetainedLicenses.DetainID = @DetainID";



            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);


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

        public static bool ReleaseDetainedLicense(int DetainID,
         int ReleasedByUserID, int ReleaseApplicationID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE dbo.DetainedLicenses
                              SET IsReleased = 1, 
                              ReleaseDate = @ReleaseDate, 
                              ReleaseApplicationID = @ReleaseApplicationID   
                              WHERE DetainID=@DetainID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


    }
}
