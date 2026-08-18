using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Create a table and index tracker
        DataTable myTable = new DataTable();
        int indexRow;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void labelSurname_Click(object sender, EventArgs e)
        {

        }

        //from the double click
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set datatable columns values
            myTable.Columns.Add("ID", typeof(int));
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Surname", typeof(string));
            myTable.Columns.Add("Age", typeof(int));

            // Add multiple rows
            myTable.Rows.Add(101, "Ryan", "Zengeni", 10);
            myTable.Rows.Add(102, "Sam", "Lewis", 20);

            // Bind data source to DataGridView
            dataGridViewTable.DataSource = myTable;
        }
    }
}
