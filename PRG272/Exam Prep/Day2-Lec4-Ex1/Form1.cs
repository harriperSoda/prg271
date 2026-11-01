using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2_Lec4_Ex1
{
    public partial class Form1 : Form
    {
        DataHandler dataHandler = new DataHandler();
        
        public Form1()
        {
            InitializeComponent();
            dataHandler.AddText();
        }

        private void BtnReadData_Click(object sender, EventArgs e)
        {
            List<int> numbers = dataHandler.ReadData();

            foreach (int number in numbers)
            {
                listView1.Items.Add(number.ToString());
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            List<int> sortedNumbers = dataHandler.DisplayData();

            foreach (int number in sortedNumbers)
            {
                listView2.Items.Add(number.ToString());
            }
        }
    }
}
