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

        public void getCategories()
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

            string query = "SELECT * FROM Categories";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

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
    }
}
