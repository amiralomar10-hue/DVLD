using System;
using ConnectionStringDVLD;
using System.Data.SqlClient;
using System.Net;
using System.Data;

namespace DVLDDataAccessLayer
{
    public class ApplicationTypesData
    {
        static string connectionString = Connection.connectionString;
        public static DataTable getAllApplicationTypes()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SP_GetAllApplicationTypes", connection);
            cmd.CommandType = CommandType.StoredProcedure; 
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }


            return dt;

        }
        public static bool getApplicationTypesByID(int id , ref string ApplicationTypeTitle , ref decimal ApplicationFees) {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SP_GetApplicationTypesByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ApplicationTypeID", id);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }

        public static bool UpdateApplicatonType(int ID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(connectionString);
   
            SqlCommand command = new SqlCommand("SP_UpdateApplicatonType", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ApplicationTypeID", ID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
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
