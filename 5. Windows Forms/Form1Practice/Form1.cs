using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myTable.Columns.Add("Name");
            myTable.Columns.Add("Surname");
            myTable.Columns.Add("Age");
        }
        DataTable myTable = new DataTable();
        int RowIndex;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelSurname_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            myTable.Rows.Add(textBoxName.Text, textBoxSurname.Text, textBoxAge.Text);
            dataGridView1.DataSource = myTable; 
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAge.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //delete row from datagridview
            dataGridView1.Rows.RemoveAt(RowIndex);

        }
    }
}
