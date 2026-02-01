using System.Data;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text;

namespace FastFoodPOS.DAL
{
    public class LoginDAL
    {
        private static string connectionString = "Data Source=DESKTOP-E268FV6;Initial Catalog=FastFoodPOS;Integrated Security=true;TrustServerCertificate=True";

        public bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT FROM Admin_Login WHERE Username=@user AND UserPassword=@pass";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    //Adding Parameters to prevent SQL Injection
                    cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;

                    try
                    {
                        con.Open();

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        return result > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Database Error: " + ex.Message);
                        return false;
                    }
                }

            }


        }
    }
}
