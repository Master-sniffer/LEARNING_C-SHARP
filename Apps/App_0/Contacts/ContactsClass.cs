using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Contacts
{
    class ContactsClass
    {
        // Getter Setter Properties
        //Acts as data carier 
        public int ContactsBox { get; set; }
        public string NamesBox { get; set; }
        public string SurnamesBox { get; set; }
        public string NumbersBox { get; set; }
        public string textsBox1 { get; set; }
        public string ChoosesGender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        // Selecting data from database

        public DataTable Select()
        {
            //Step one - connection 
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                // Write SQL query
                string sql = "SELECT * FROM Table_0";
                SqlCommand cmd = new SqlCommand(sql, conn); // Creating cmd , which uses query and connection
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Creating sql DataAdapter using cmd
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        public bool Insert (ContactsClass C)
        {

            //Creating default return type and setting it's value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Table_0 (FirstName, Surname, ContactNumb,Address,Gender) VALUES (@FirstName, @Surname, @ContactNumb,@Address,@Gender)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Create parametrs to add data
                cmd.Parameters.AddWithValue("@FirstName", C.NamesBox);
                cmd.Parameters.AddWithValue("@Surname", C.SurnamesBox);
                cmd.Parameters.AddWithValue("@ContactNumb", C.NumbersBox);
                cmd.Parameters.AddWithValue("@Address", C.textsBox1);
                cmd.Parameters.AddWithValue("@Gender", C.ChoosesGender);

                conn.Open();
                int rows = cmd.ExecuteNonQuery(); 
                // if the query runs successfully than the number of rows will be greater than 0 
                if (rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

            }finally
            {
                conn.Close();
            }
            
            return isSuccess;
        }

        // Method to update info in the table

        public bool Update (ContactsClass C)
        {
            // Create default boolean
            bool isSuccessful = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE Table_0 SET FirstName=@FirstName, Surname=@Surname, ContactNumb=@ContactNumb,Address=@Address,Gender=@Gender WHERE Contactid=@Contactid";

                //Creating an SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Create Parametrs
                cmd.Parameters.AddWithValue("@FirstName", C.NamesBox);
                cmd.Parameters.AddWithValue("@Surname", C.SurnamesBox);
                cmd.Parameters.AddWithValue("@ContactNumb", C.NumbersBox);
                cmd.Parameters.AddWithValue("@Address", C.textsBox1);
                cmd.Parameters.AddWithValue("@Gender", C.ChoosesGender);
                cmd.Parameters.AddWithValue("@Contactid", C.ContactsBox);
                // Open Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                // IF the size of the query is bigger than 0, than show smth
                if (rows > 0)
                {
                    isSuccessful = true;
                }
            }
            catch (Exception ex) { 
            } finally
            {
                conn.Close();
            }
            return isSuccessful;
        }

        public bool Delete (ContactsClass C)
        {
            bool isSuccessful = false;

            SqlConnection conn = new SqlConnection(myconnstring);


            try
            {
                string sql = "DELETE FROM Table_0 WHERE @Contactid=Contactid";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Contactid", C.ContactsBox);
                //Open Connectiong
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccessful = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


            return isSuccessful;
        }
    }


}
