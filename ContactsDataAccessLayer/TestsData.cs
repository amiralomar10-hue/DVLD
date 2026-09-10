using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionStringDVLD;
namespace DVLDDataAccessLayer
{
public class clsTestData
{
    static string connectionString = ConnectionStringDVLD.Connection.connectionString;

    public static bool GetTestInfoByID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Tests WHERE TestID = @TestID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestID", TestID);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        TestAppointmentID = (int)reader["TestAppointmentID"];
                        TestResult = (bool)reader["TestResult"];
                        Notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];
                        CreatedByUserID = (int)reader["CreatedByUserID"];
                    }
                }
            }
        }
        return isFound;
    }

    public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
    {
        int testID = -1;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                                 VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                                 SELECT SCOPE_IDENTITY();";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                command.Parameters.AddWithValue("@TestResult", TestResult);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    testID = insertedID;
            }
        }
        return testID;
    }

    public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"UPDATE Tests 
                                 SET TestAppointmentID = @TestAppointmentID,
                                    TestResult = @TestResult,
                                     Notes = @Notes,
                                     CreatedByUserID = @CreatedByUserID
                                 WHERE TestID = @TestID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", TestID);
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    command.Parameters.AddWithValue("@TestResult", TestResult);
                    command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected > 0;
        }

        public static bool DeleteTest(int TestID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Tests WHERE TestID = @TestID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", TestID);
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected > 0;
        }

        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tests";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    }
}

