using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1_2Revision
{
    public partial class Form1 : Form
    {
        DataHandler handler = new DataHandler();
        public Form1()
        {
            InitializeComponent();
            handler.AddData();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> marks = handler.ReadData();

            foreach (int mark in marks)
            {
                listView1.Items.Add(mark.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            List<int> Asc = handler.SortAsc();

            foreach (int number in Asc)
            {
                listView2.Items.Add(number.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            List<int> desc = handler.SortDesc();

            foreach (int number in desc)
            {
                listView2.Items.Add(number.ToString());
            }
        }
    }
}
