using System;
using System.Data;
using System.Data.SqlClient;
namespace DVLDDataAccessLayer
{
    public class clsApplicationDataAccess
    {
        private static string connectionString =ConnectionStringDVLD.Connection.connectionString ;

        public static bool GetApplicationInfoByID(int applicationID, ref int applicantPersonID,
            ref DateTime applicationDate, ref int applicationTypeID, ref int applicationStatus,
            ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                string query = @"INSERT INTO Applications 
                                (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                                VALUES 
                                (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                                SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                string query = @"UPDATE Applications
                                SET ApplicantPersonID = @ApplicantPersonID,
                                    ApplicationDate = @ApplicationDate,
                                    ApplicationTypeID = @ApplicationTypeID,
                                    ApplicationStatus = @ApplicationStatus,
                                    LastStatusDate = @LastStatusDate,
                                    PaidFees = @PaidFees,
                                    CreatedByUserID = @CreatedByUserID
                                WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                string query = @"UPDATE Applications
                                SET 
                                    ApplicationStatus = 3
                                WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                string query = @"UPDATE Applications
                                SET 
                                    ApplicationStatus = 2
                                WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                string query = "SELECT ApplicationID , ApplicantPersonID ,ApplicationDate ,ApplicationTypeID ,\r\n   CASE\r\n   WHEN Applications.ApplicationStatus = 1 THEN 'NEW'\r\n   WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'\r\n   ELSE 'Completed'\r\n   END as ApplicationStatus , LastStatusDate ,PaidFees ,CreatedByUserID\r\n  FROM Applications\r\n  ";
            //    string query = "SELECT \r\n    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AS [L.D.L.AppID],\r\n    LicenseClasses.ClassName AS [Driving Class],\r\n    People.NationalNo AS [National No],\r\n    People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') + People.LastName AS [Full Name],\r\n    Applications.ApplicationDate AS [Application Date],\r\n    (\r\n        SELECT COUNT(TestAppointments.TestTypeID)\r\n        FROM TestAppointments \r\n        INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID\r\n        WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n          AND Tests.TestResult = 1\r\n    ) AS [Passed Tests],\r\n    CASE \r\n        WHEN Applications.ApplicationStatus = 1 THEN 'New'\r\n        WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'\r\n        WHEN Applications.ApplicationStatus = 3 THEN 'Completed'\r\n        ELSE 'Unknown'\r\n    END AS [Status]\r\nFROM LocalDrivingLicenseApplications\r\nINNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID\r\nINNER JOIN LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\nINNER JOIN People ON Applications.ApplicantPersonID = People.PersonID;";
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
                string query = "SELECT 1 FROM Applications WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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

