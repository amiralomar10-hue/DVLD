using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConnectionStringDVLD;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Security.Policy;

namespace DVLDDataAccessLayer
{
    public class CountriesData
    {
        public CountriesData() { }
        static string connectionString = ConnectionStringDVLD.Connection.connectionString;
        public static DataTable getAllCountries()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Countries\r\n";
            SqlCommand cmd = new SqlCommand(query, connection);

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
        public static bool getCountryNameByID(int id , ref string CountryName)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT * FROM Countries where CountryID = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                     CountryName = (string)reader["CountryName"];
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
    }
}
