using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Airline_company.Ticket
{
    internal class passengerscs
    {

        public int PassengerNumber { get; set; }
        public string PassportNumber { get; set; }
        public string PED { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string PrimaryContact { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        public string DepartDate { get; set; }
        public string ReturnDate { get; set; }
        public string TicketType { get; set; }
        public string Class { get; set; }

        static string myconnstrng = "Data Source=localhost;Initial Catalog=AirLine;Persist Security Info=True;User ID=sa; Password=ab12AB34";




        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM PassengerInfo1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        public bool Insert(passengerscs std)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO PassengerInfo1 (Title, PassportNumber, PED, FirstName, LastName, Gender, Nationality, PrimaryContact, CountryCode, PhoneNumber, Email, CityFrom, CityTo, DepartDate, ReturnDate, TicketType, Class) values (@Title, @PassportNumber, @PED, @FirstName, @LastName, @Gender, @Nationality, @PrimaryContact, @CountryCode, @PhoneNumber, @Email, @CityFrom, @CityTo, @DepartDate, @ReturnDate, @TicketType, @Class)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Title", std.Title);
                cmd.Parameters.AddWithValue("@PassportNumber", std.PassportNumber);
                cmd.Parameters.AddWithValue("@PED", std.PED);
                cmd.Parameters.AddWithValue("@FirstName", std.FirstName);
                cmd.Parameters.AddWithValue("@LastName", std.LastName);
                cmd.Parameters.AddWithValue("@Gender", std.Gender);
                cmd.Parameters.AddWithValue("@Nationality", std.Nationality);
                cmd.Parameters.AddWithValue("@PrimaryContact", std.PrimaryContact);
                cmd.Parameters.AddWithValue("@CountryCode", std.CountryCode);
                cmd.Parameters.AddWithValue("@PhoneNumber", std.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", std.Email);
                cmd.Parameters.AddWithValue("@CityFrom", std.CityFrom);
                cmd.Parameters.AddWithValue("@CityTo", std.CityTo);
                cmd.Parameters.AddWithValue("@DepartDate", std.DepartDate);
                cmd.Parameters.AddWithValue("@ReturnDate", std.ReturnDate);
                cmd.Parameters.AddWithValue("@TicketType", std.TicketType);
                cmd.Parameters.AddWithValue("@Class", std.Class);


                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

       


        public bool Delete(passengerscs std)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM PassengerInfo1 WHERE PassengerNumber = @PassengerNumber ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PassengerNumber", std.PassengerNumber);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Search(string key, DataTable dt)
        {
            bool isSuccess = false;

            try
            {
                string query = "SELECT * FROM PassengerInfo1 WHERE PassengerNumber LIKE '%' + @key + '%' OR FirstName LIKE '%' + @key + '%'";

                using (SqlConnection con = new SqlConnection(myconnstrng))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@key", key);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                            isSuccess = true;
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }


            return isSuccess;
        }

        public bool Update(passengerscs std, string pass)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE PassengerInfo1 SET Title=@Title, PassportNumber=@PassportNumber, PED=@PED, FirstName=@FirstName, LastName=@LastName, Gender=@Gender, Nationality=@Nationality, PrimaryContact=@PrimaryContact, CountryCode=@CountryCode, PhoneNumber=@PhoneNumber, Email=@Email, CityFrom=@CityFrom, CityTo=@CityTo, DepartDate=@DepartDate, ReturnDate=@ReturnDate, TicketType=@TicketType, Class=@Class WHERE PassengerNumber =@PassengerNumber";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@PassengerNumber",pass);
                cmd.Parameters.AddWithValue("@Title", std.Title);
                cmd.Parameters.AddWithValue("@PassportNumber", std.PassportNumber);
                cmd.Parameters.AddWithValue("@PED", std.PED);
                cmd.Parameters.AddWithValue("@FirstName", std.FirstName);
                cmd.Parameters.AddWithValue("@LastName", std.LastName);
                cmd.Parameters.AddWithValue("@Gender", std.Gender);
                cmd.Parameters.AddWithValue("@Nationality", std.Nationality);
                cmd.Parameters.AddWithValue("@PrimaryContact", std.PrimaryContact);
                cmd.Parameters.AddWithValue("@CountryCode", std.CountryCode);
                cmd.Parameters.AddWithValue("@PhoneNumber", std.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", std.Email);
                cmd.Parameters.AddWithValue("@CityFrom", std.CityFrom);
                cmd.Parameters.AddWithValue("@CityTo", std.CityTo);
                cmd.Parameters.AddWithValue("@DepartDate", std.DepartDate);
                cmd.Parameters.AddWithValue("@ReturnDate", std.ReturnDate);
                cmd.Parameters.AddWithValue("@TicketType", std.TicketType);
                cmd.Parameters.AddWithValue("@Class", std.Class);

                con.Open();

                int row = cmd.ExecuteNonQuery();

                if (row == 1)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
    }
}
