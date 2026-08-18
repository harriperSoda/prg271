using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        // Stores the index of the selected DataGridView row so it can be updated or accessed later.
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

            // Bind data source to DataGridView - the table created above is now the data source for the DataGridView
            dataGridViewTable.DataSource = myTable;
        }

        //from double click of 'add' button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Add row from textboxes to DataTable
            //adds the objects' values (from textboxes) to the table myTable rows
            myTable.Rows.Add(textBoxID.Text, textBoxName.Text, textBoxSurname.Text, textBoxAge.Text);

            // Displays the data stored in myTable in the DataGridView.
            dataGridViewTable.DataSource = myTable;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //record which row was clicked 
            DataGridViewRow newDataRow = dataGridViewTable.Rows[indexRow];

            newDataRow.Cells[0].Value = textBoxID.Text;
            newDataRow.Cells[1].Value = textBoxName.Text;
            newDataRow.Cells[2].Value = textBoxSurname.Text;
            newDataRow.Cells[3].Value = textBoxAge.Text;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //select a row and delete it from your at table inside your data grid view
            if (dataGridViewTable.CurrentCell == null) return;
            int rowIndex = dataGridViewTable.CurrentCell.RowIndex;
            dataGridViewTable.Rows.RemoveAt(rowIndex);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAge.Clear();
        }

        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
