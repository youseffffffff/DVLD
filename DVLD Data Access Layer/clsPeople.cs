using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DVLD_Data_Access_Layer

{
    public class clsPeople
    {
        public static DataTable GetAllPeople()
        {
            DataTable People = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, " +
                   "case Gendor " +
                   "when 0 Then 'Male' " +
                   "else 'Female' End as Gendor, " +
                   "CountryName From People Join Countries On NationalityCountryID = CountryID ";

            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    People.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                People = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            People.TableName = "People";

            return People;
        }
        public static DataTable GetAllCountries()
        {
            DataTable People = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select * From Countries";

            SqlCommand Command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    People.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                People = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return People;
        }
        public static string GetCountryNameByCountryID(int CountryID)
        {
            string CountryName = null;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select CountryName From Countries Where CountryID = @CountryID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                    CountryName = (string) Reader["CountryName"];

                Reader.Close();
            }
            catch (Exception ex)
            {
                CountryName = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return CountryName;
        }
        public static int GetCountryIDByCountryName(string CountryName)
        {
            int CountryID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select CountryID From Countries Where CountryName = @CountryName";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                    CountryID = (int)Reader["CountryID"];

                Reader.Close();
            }
            catch (Exception ex)
            {
                CountryID = -1;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return CountryID;
        }


        public static DataTable GetAllPeopleOrderByColumn(string textLike, string Column)
        {
            List<string> allowedColumns = new List<string> { "PersonID", "NationalNo", "FirstName", "SecondName",
                "ThirdName", "LastName", "DateOfBirth", "Gendor", "Address", "Phone", "Email", "CountryName", "ImagePath"};

            if (!allowedColumns.Contains(Column)) return null;

            DataTable People = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

   


            string query = @"Select PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, " +
                   "case Gendor " +
                   "when 0 Then 'Male' " +
                   "else 'Female' End as Gendor " +
                   ",Address,Phone, Email, CountryName, ImagePath  From People Join Countries On NationalityCountryID = CountryID " +
                   $"Where {Column} Like @textLike ";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@textLike", textLike + "%");

            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    People.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                People = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return People;
        }
   
        public static bool FindPersonByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor
            , ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select * From People Where PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    PersonID = (int)Reader["PersonID"];
                    NationalNo = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gendor = Convert.ToInt32(Reader["Gendor"]);
                    Address = (string)Reader["Address"];
                    Phone = Convert.ToString(Reader["Phone"]);
                    Email = Convert.ToString(Reader["Email"]);
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    ImagePath = Convert.ToString(Reader["ImagePath"]);

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


        public static bool FindPersonByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor
            , ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select * From People Where NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    PersonID = (int)Reader["PersonID"];
                    NationalNo = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gendor = Convert.ToInt32(Reader["Gendor"]);
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    ImagePath = (string)Reader["ImagePath"];

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


        public static bool DeletePersonByID(int PersonID)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete From People Where PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);


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

            return (RowsEffected > 0);
        }


        public static int AddPerson(string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, int Gendor
            , string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int PersonID = -1;
            


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
                @"Insert Into People Values (@NationalNo, @FirstName, @SecondName, @ThirdName," +
                " @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath)" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);


            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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

            return PersonID;
        }


        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, int Gendor
            , string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update  People  
                            set NationalNo = @NationalNo, 
                                FirstName = @FirstName, 
                                SecondName = @SecondName, 
                                ThirdName = @ThirdName, 
                                LastName = @LastName, 
                                DateOfBirth = @DateOfBirth,
                                Gendor = @Gendor,
                                Address = @Address,
                                Phone = @Phone,
                                Email = @Email,
                                NationalityCountryID = @NationalityCountryID,
                                ImagePath = @ImagePath
                                where PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);

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


        

    }
}