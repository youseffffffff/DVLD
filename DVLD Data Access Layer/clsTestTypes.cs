using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Access_Layer
{
    public class clsTestTypes
    {

        public static DataTable GetAllTestTypes()
        {
            DataTable TestTypes = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select * From TestTypes";

            SqlCommand Command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    TestTypes.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {
                TestTypes = null;
                clsLogTheExError.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            TestTypes.TableName = "TestTypes";  
            return TestTypes;
        }


        public static bool FindTestTypeByID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref double TestTypeFees)
        {
            bool IsFill = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Select * From TestTypes Where TestTypeID = @TestTypeID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    TestTypeTitle = Convert.ToString(Reader["TestTypeTitle"]);
                    TestTypeFees = Convert.ToDouble(Reader["TestTypeFees"]);
                    TestTypeDescription = Convert.ToString(Reader["TestTypeDescription"]);

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

        public static bool UpdateTestTypeByID(int TestTypeID, string TestTypeTitle, string TestTypeDescription, double TestTypeFees)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update TestTypes " +
                         "set TestTypeTitle = @TestTypeTitle, TestTypeFees = @TestTypeFees, TestTypeDescription = @TestTypeDescription " +
                         "Where TestTypeID = @TestTypeID";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            Command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            Command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);


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
