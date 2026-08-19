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
            
            
        }

        DataTable myTable = new DataTable();
        int rowIndex;
       

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
            myTable.Rows.Add(textBoxName.Text, textBoxSurname.Text, int.Parse(textBoxAge.Text));
            dataGridView1.DataSource = myTable;
        }
           

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxSurname.Clear(); 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTable.Columns.Add("Name", typeof(string));    
            myTable.Columns.Add("Surname", typeof(string));
            myTable.Columns.Add("Age", typeof(int));
        }
    }
}
