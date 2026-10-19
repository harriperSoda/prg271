using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DataHandler
    {
        string connectionLoc = @"Server=SODAPC\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=SSPI;";
        //this is the connection string
        //we have a connection string but no SqlConnection object exists and nothing is connected

        public void getCategories()
        {
            SqlConnection connection = new SqlConnection(connectionLoc); //instantate a new SqlConnection and configure it using the details in the connection string   

            try
            {
                connection.Open();
                Console.WriteLine("Connection Opened Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("You are not conneted");
            }

            string query = "SELECT * FROM Categories";

            SqlCommand command = new SqlCommand(query, connection); //the object that represeents the SQL command to be executed against the database

            SqlDataReader reader = command.ExecuteReader(); //SqlDataReader is used to read the data fetched when the command executes, and reader.Read() is then used to obtain each row.

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine(
                        "{0}\t{1}",
                        reader.GetInt32(0),
                        reader.GetString(1)
                        );
                }

            }
            else
            {
                Console.WriteLine("No rows found");
            }
            reader.Close();
            connection.Close();
        }
        public void insertData()
        {
            SqlConnection connection = new SqlConnection(connectionLoc);

            try
            {
                connection.Open();
                Console.WriteLine("Connection Opened Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("You are not conneted");
            }

            string query = "INSERT INTO Categories (CategoryName, Description) VALUES ('Vegan', 'A diet that excludes all animal products')"; 

            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery(); //This method is used to execute the SQL command that does not return any data, such as INSERT, UPDATE, or DELETE.
            Console.WriteLine("Data Inserted Successfully");
            
            connection.Close();
        }
    }
}
