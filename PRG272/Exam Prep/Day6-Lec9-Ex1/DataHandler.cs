using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day6_Lec9_Ex1
{
    internal class DataHandler
    {

      public DataHandler()
        {

        }
        string conn = "Server = SodaPC\\SQLEXPRESS; Initial Catalog = NORTHWND; Integrated Security = true;";

        public void AddNewRow()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
                Console.WriteLine("======");
                Console.WriteLine("Connection Open");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query = "INSERT INTO Categories (CategoryName, Description) VALUES('Octopus', 'Sea Food from Wuahn')";
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            Console.WriteLine("Table has been given a new row");
            Console.WriteLine("Connection closed");
            Console.WriteLine("======");
            connection.Close();

        }
        public void UpdateId3()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
                Console.WriteLine("======");

                Console.WriteLine("Connection Oppened");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query = "UPDATE Categories SET CategoryName = 'Bakery' WHERE CategoryID = 3";
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            Console.WriteLine("Table has been updated");

            connection.Close();
            Console.WriteLine("Connection closed");
            Console.WriteLine("======");

        }
        public void DeleteRow()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
                Console.WriteLine("======");

                Console.WriteLine("Connection Oppened");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query = "DELETE FROM Categories WHERE CategoryName = 'Vegan'";

            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            Console.WriteLine("Table row has been deleted");
            connection.Close();
            Console.WriteLine("======");

        }
        public void RowCount()
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
                Console.WriteLine("======");

                Console.WriteLine("Connection Oppened");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query = "SELECT COUNT (*) FROM Categories";

            SqlCommand command = new SqlCommand(query, connection);

            int rowCount = (int)command.ExecuteScalar();
            Console.WriteLine($"Table has {rowCount} rows");
            Console.WriteLine("Connection closed");
            connection.Close();
            Console.WriteLine("======");

        }
    }
}
