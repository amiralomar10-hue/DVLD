using System;
using System.Data;
using System.Data.SqlClient;
using ConnectionStringDVLD;
namespace DVLDDataAccessLayer
{
    public class clsTestTypeData
    {
     
        private static string connectionString = ConnectionStringDVLD.Connection.connectionString;

        
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TestTypes";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle Exception
                    }
                }
            }

            return dt;
        }

        
        public static bool GetTestTypeByID(int testTypeID, ref string title, ref string description, ref decimal fees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                title = (string)reader["TestTypeTitle"];
                                description = reader["TestTypeDescription"] != DBNull.Value ? (string)reader["TestTypeDescription"] : "";
                                fees = Convert.ToDecimal(reader["TestTypeFees"]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                }
            }

            return isFound;
        }

      
        public static bool UpdateTestType(int testTypeID, string title, string description, decimal fees)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE TestTypes 
                                SET TestTypeTitle = @Title, 
                                    TestTypeDescription = @Description, 
                                    TestTypeFees = @Fees 
                                WHERE TestTypeID = @TestTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);
                    command.Parameters.AddWithValue("@Fees", fees);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }
    }
}