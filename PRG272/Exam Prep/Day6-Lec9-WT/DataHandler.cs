using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day6_Lec9_WT
{
    internal class DataHandler
    {

        //constructor
        public DataHandler()
        {

        }
        string conn = "Server= SodaPC\\SQLEXPRESS; Initial Catalog= NORTHWND; Integrated Security=true;";

        public void GetCategories()
        {
            //Create SQL connection object, which uses connection string

            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
                Console.WriteLine("Connection Open");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Set SQL query
            string query = "SELECT * FROM Categories";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) //checks is sql query has returned atleast 1 row
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}",
                        reader.GetInt32(0), //Retrieves the CategoryID as an integer from column index 0 of the current row.
                        reader.GetString(1)); //Retrieves the CategoryName as a string from column index 1 of the current row.
                }
            }
            else
            {
                Console.WriteLine("No rows found in category table");
            }
            reader.Close();
            connection.Close();
        }
        public void InsertData()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
                Console.WriteLine("Connection open");
                Console.WriteLine("================");
            }
            catch (Exception )
            {
                Console.WriteLine("You are not connected");
            }

            string query = "INSERT INTO Categories (CategoryName, Description) VALUES ('Vegan', 'Nice Food')";

            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();

            connection.Close();

        }
        public void UpdateData()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
                Console.WriteLine("Connection to update data openn");

            }
            catch (Exception)
            {
                Console.WriteLine("Something failed");
            }

            string query = "UPDATE Categories SET CategoryName = 'Exotic Crap' WHERE CategoryID = '7'";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            Console.WriteLine("Update done");
            connection.Close();
        }
        public void DeleteData()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
                Console.WriteLine("Connection for delete open");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query = "DELETE FROM Categories WHERE CategoryID = '11'";

            SqlCommand command = new SqlCommand();

            command.CommandText = query;
            command.Connection = connection;
            command.ExecuteNonQuery();

            connection.Close();

        }
        public void GetSingularValue()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
                Console.WriteLine("Connection for obtaining single value open");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query = "SELECT COUNT (*) FROM Categories";

            SqlCommand command = new SqlCommand(query, connection);
            int count = (int)command.ExecuteScalar();

            Console.WriteLine($"our table has {count} rows");

            connection.Close();
        }
    }
}
