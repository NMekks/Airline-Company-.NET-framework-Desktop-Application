using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_company.Loginclass
{
    internal class loginclass
    {


        public string username { get; set; }
        public string password { get; set; }


        public static string ConString = "Data Source=localhost;Initial Catalog=AirLine;Persist Security Info=True;User ID=sa; Password=ab12AB34";

        public bool ReadData(loginclass lc)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(ConString);
            try
            {
                using (con)
                {
                    con.Open();
                    string sql = "SELECT * From Login Where Username = @username AND Password =@password";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@username", lc.username);
                        cmd.Parameters.AddWithValue("@password", lc.password);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            isSuccess = true;
                        }
                        else
                        {
                            //isSuccess = false;
                        }

                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }


    }
}
