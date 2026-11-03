using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Added namespace which gives access to classes that allow us to work with SQL Server data
using System.Data.SqlClient;

namespace Day4_Lec8_WT
{
    public partial class Form1 : Form
    {
        SqlConnection connection; //create the database connection object
        public Form1()
        {
            InitializeComponent();

            connection = new SqlConnection(
                "Server=SodaPC\\SQLEXPRESS; Initial Catalog = NORTHWND; Integrated Security=true;"); //instantiate and configure it
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MessageBox.Show("Connection open");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create SqlCommand object and bind it to a command
            SqlCommand command = new SqlCommand("SELECT * FROM CATEGORIES", connection);

            //Create a SqlDataReader object that reads data from SQL table 
            SqlDataReader reader = command.ExecuteReader();

            //It gives the DataGridView a bindable data source, so the grid can automatically display the rows and columns returned by the query.
            BindingSource source = new BindingSource();


            source.DataSource = reader;

            dataGridView1.DataSource = source;

            //1. SqlConnection --> creates and configures route to SQL server
            //2. SqlCommand --> Holds sql instruction
            //3. cmd.ExecuteReader --> Send sql command through connection
            //4. SqlDataReader reader --> recieves rown returned 
            //5. BindingSource source -->  Takes reader as its DataSource so the returned rows can be exposed to a UI control
            // 6. dataGridView1.DataSource = source --> The DataGridView binds to that source and displays the rows/columns
        }
    }
}
