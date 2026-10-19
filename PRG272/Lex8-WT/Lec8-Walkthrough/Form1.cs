using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lec8_Walkthrough
{
    public partial class Form1 : Form
    {
        //Create connection object
        SqlConnection connection;
        public Form1()
        {
            
            InitializeComponent();
            //Object is instantiated with connection string
            connection = new SqlConnection(@"Server=SODAPC\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=SSPI;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open(); //Open the connection
                MessageBox.Show("Connection Opened Successfully");
                 

            }
            catch (Exception ex) //Handles exception if thrown
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create SqlCommand object and bind to an SQL SELECT command
            SqlCommand command = new SqlCommand("SELECT * FROM Categories", connection); //copnnection tells which connectionto use

            //Create SqlDataReader that reads data from table 
            SqlDataReader reader = command.ExecuteReader(); //executes the SqlCommand against the database using the connection, and returns the results as a SqlDataReader

            //Create a binding source object
            BindingSource source = new BindingSource(); //bind the data coming from reader to the UI control.

            source.DataSource = reader;

            //Bind the DataGridView to the source
            dataGridView1.DataSource = source;

            connection.Close();
        }
    }
}
