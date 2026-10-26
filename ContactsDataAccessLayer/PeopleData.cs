using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionStringDVLD;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Collections;
using System.Net;
using System.Security.Policy;

namespace DVLDDataAccessLayer
{

    public class PeopleData
    {
        static string connectionString = ConnectionStringDVLD.Connection.connectionString;
        public static DataTable getAllPeople()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SP_GetAllPeople", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
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

        public static int AddNewPeople(string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, int gendor, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            int PeopleID = -1;

            SqlConnection connection = new SqlConnection(connectionString);
           
            SqlCommand cmd = new SqlCommand("SP_AddNewPeople", connection);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@SecondName", secondName);

            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", gendor);
            cmd.Parameters.AddWithValue("@Address", address);

            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
            if (!string.IsNullOrEmpty(thirdName))
                cmd.Parameters.AddWithValue("@ThirdName", thirdName);
            else
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            if (!string.IsNullOrEmpty(email))
                cmd.Parameters.AddWithValue("@Email", email);
            else
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);

            if (!string.IsNullOrEmpty(imagePath))
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PeopleID = insertedID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return PeopleID;
        }

        public static bool getPersonByPersonID(int personID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(connectionString);
         
            SqlCommand cmd = new SqlCommand("SP_GetPersonByPersonID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@person", personID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    NationalNo = (string)reader["NationalNo"];
                    isFound = true;
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }

                    else
                    {
                        ThirdName = "";
                    }
                    LastName = (string)reader["LastName"];
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }

                    else
                    {
                        Email = "";
                    }
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    Gendor = Convert.ToInt32(reader["Gendor"]);
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }

                    else
                    {
                        ImagePath = "";
                    }
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

        public static bool UpdatePerson(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, string email, int gendor, string phone, string address, int nationalityCountryID, DateTime dateOfBirth, string imagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(connectionString);
      
            SqlCommand cmd = new SqlCommand("SP_UpdatePerson", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@personID", personID);
            cmd.Parameters.AddWithValue("@nationalNo", nationalNo);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@secondName", secondName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@gendor", gendor);
            cmd.Parameters.AddWithValue("@address", address);

            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@nationalityCountryID", nationalityCountryID);
            if (!string.IsNullOrEmpty(thirdName))
                cmd.Parameters.AddWithValue("@thirdName", thirdName);
            else
                cmd.Parameters.AddWithValue("@thirdName", DBNull.Value);

            if (!string.IsNullOrEmpty(email))
                cmd.Parameters.AddWithValue("@email", email);
            else
                cmd.Parameters.AddWithValue("@email", DBNull.Value);

            if (!string.IsNullOrEmpty(imagePath))
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();
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
        public static bool GetPersonByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPersonByNationalNo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "";
                                LastName = (string)reader["LastName"];
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                                Phone = (string)reader["Phone"];
                                Address = (string)reader["Address"];
                                Gendor = Convert.ToInt32(reader["Gendor"]);
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                                ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
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
        public static bool DeletePerson(int personID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(connectionString);
  
            SqlCommand cmd = new SqlCommand("SP_DeletePerson", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@personID", personID);
            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }
        public static bool IsExistPerson(int PersonID)
        {
            bool isFound = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsExistPerson", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
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
        public static bool IsExistPerson(string NationalNo)
        {
            bool isFound = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
              
                using (SqlCommand cmd = new SqlCommand("SP_IsExistPersonByNo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
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

     
    }
}
