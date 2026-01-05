using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DVLD_Data_Access_Layer
{
    public class clsUsers
    {
        public static DataTable GetAllUsers()
        {
            DataTable Users = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select UserID, PersonID, UserName,
                             Case IsActive 
                             When 1 Then 'Yes'
                             else 'No' End As IsActive
                             
                             From Users";

            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    Users.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                Users = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            Users.TableName = "Users";
            return Users;
        }

        public static bool DeleteUserByID(int UserID)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete From Users Where UserID = @UserID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);


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

        public static bool FindUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select * From  Users Where UserID = @UserID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    IsFill = true;
                    PersonID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];


                    
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

        public static bool FindUserByUserNameAndPassword(ref int UserID, ref int PersonID, string UserName, string Password, ref bool IsActive)
        {
            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select * From Users Where  UserName = @UserName And Password = @Password";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];


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

        public static int AddUser(int PersonID, string UserName, string Password, bool IsActive)
        {


            int UserID = -1;



            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query =
                @"Insert Into Users Values (@PersonID, @UserName, @Password, @IsActive)" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
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

            return UserID;
        }
        
        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update Users 
                            set PersonID = @PersonID, 
                                UserName = @UserName, 
                                Password = @Password,   
                                IsActive = @IsActive
                                where UserID = @UserID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

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
       
        public static DataTable GetAllUsersOrderByColumn(string textLike, string Column)
        {
            List<string> allowedColumns = new List<string> { "UserID", "PersonID", "UserName", "Password", "IsActive" };

            if (!allowedColumns.Contains(Column)) return null;

            DataTable Users = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query = $@"Select UserID, PersonID, UserName, 
                             Case IsActive 
                             When 1 Then 'Yes'
                             else 'No' End As IsActive
                             
                             From Users
                             Where {Column} Like @textLike";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@textLike", textLike + "%");

            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    Users.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                Users = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            Users.TableName = "Users";

            return Users;
        }




    }
}
