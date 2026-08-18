using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction_to_froms
{
    public partial class Form1 : Form
    {
        //constructor
        public Form1()
        {
            InitializeComponent();
        }

        //create a table
        DataTable myTable = new DataTable();
        int indexRow;

        private void Form1_Load(object sender, EventArgs e)
        {
            //set data table colums
            myTable.Columns.Add("ID:", typeof(int));
            myTable.Columns.Add("Name:", typeof(string));
            myTable.Columns.Add("Surname:", typeof(string));
            myTable.Columns.Add("Age:", typeof(int));


            //set data table rows(sample)
            myTable.Rows.Add(101, "Aden", "Jansen", 20);
            myTable.Rows.Add(102, "Jordan", "Liao", 21);
            myTable.Rows.Add(103, "Aman", "Herp", 24);
            myTable.Rows.Add(104, "Viashin", "Naidoo", 19);

            //bind the grid view
            dataGridViewTable.DataSource = myTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myTable.Rows.Add(textBoxId.Text, textBoxName.Text, textBoxSurname.Text, textBoxAge.Text);
            dataGridViewTable.DataSource = myTable;
        }

        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;//recommeded guard when the header is clicked

            indexRow = e.RowIndex;//get the selected tow index

            //create object of type daataGirdviewrow
            DataGridViewRow row = dataGridViewTable.Rows[indexRow];

            //get each cell in each row
            //pass it to the respective text box
            textBoxId.Text = row.Cells[0].Value.ToString();
            textBoxName.Text = row.Cells[1].Value.ToString();
            textBoxSurname.Text = row.Cells[2].Value.ToString();
            textBoxAge.Text = row.Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridViewTable.Rows[indexRow];

            newDataRow.Cells[0].Value = textBoxId.Text;
            newDataRow.Cells[1].Value = textBoxName.Text;
            newDataRow.Cells[2].Value = textBoxSurname.Text;
            newDataRow.Cells[3].Value = textBoxAge.Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //select a row and delete it from your at table inside your data grid view
            if (dataGridViewTable.CurrentCell == null) return;
            int rowIndex = dataGridViewTable.CurrentCell.RowIndex;
            dataGridViewTable.Rows.RemoveAt(rowIndex);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAge.Clear();

        }
    }
}
