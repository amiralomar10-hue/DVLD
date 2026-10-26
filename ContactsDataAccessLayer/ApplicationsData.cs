using System;
using System.Data;
using System.Data.SqlClient;
using ConnectionStringDVLD;

namespace DVLDDataAccessLayer
{
    public class clsApplicationDataAccess
    {
        private static string connectionString = Connection.connectionString;

        public static bool GetApplicationInfoByID(int applicationID, ref int applicantPersonID,
            ref DateTime applicationDate, ref int applicationTypeID, ref int applicationStatus,
            ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetApplicationInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                applicantPersonID = (int)reader["ApplicantPersonID"];
                                applicationDate = (DateTime)reader["ApplicationDate"];
                                applicationTypeID = (int)reader["ApplicationTypeID"];
                                applicationStatus = Convert.ToInt32(reader["ApplicationStatus"]);
                                lastStatusDate = (DateTime)reader["LastStatusDate"];
                                paidFees = Convert.ToDecimal(reader["PaidFees"]);
                                createdByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewApplication(int applicantPersonID, DateTime applicationDate,
            int applicationTypeID, int applicationStatus, DateTime lastStatusDate,
            decimal paidFees, int createdByUserID)
        {
            int applicationID = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
             
                using (SqlCommand command = new SqlCommand("SP_AddNewApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            applicationID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("STOP Application" + ex.Message);

                      
                    }
                }
            }

            return applicationID;
        }

        public static bool UpdateApplication(int applicationID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeID, int applicationStatus, DateTime lastStatusDate,
            decimal paidFees, int createdByUserID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

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
        public static bool ChanageApplicationStatusToComplete(int applicationID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
          
                using (SqlCommand command = new SqlCommand("SP_ChanageApplicationStatusToComplete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);

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
        public static bool ChanageApplicationStatusToCancel(int applicationID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_ChanageApplicationStatusToCancel", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                                     
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
        public static bool DeleteApplication(int applicationID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_DeleteApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);

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

      
        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                 using (SqlCommand command = new SqlCommand("SP_GetAllApplications", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
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
                        // التعامل مع الاستثناء
                    }
                }
            }

            return dt;
        }

        public static bool IsApplicationExist(int applicationID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsApplicationExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        isFound = (result != null);
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                }
            }

            return isFound;
        }




    }
}

