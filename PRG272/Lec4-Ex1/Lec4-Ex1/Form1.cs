using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace Lec4_Ex1

{
    public partial class Form1 : Form
    {
        string filepath = @"C:\Users\VMothie\Documents\prg271\PRG272\Lec4-Ex1\Lec4-Ex1\ex4Text.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (File.Exists(filepath))
            {
                List<string> numbers = File.ReadAllLines(filepath).ToList();

                foreach (string number in numbers)
                {
                    lstView1.Items.Add(number);
                }
            }
            else
            {
                MessageBox.Show("File not found: " + filepath);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(filepath))
            {
                List<int> numbers = File.ReadAllLines(filepath).Select(int.Parse).ToList();

                numbers.Sort();

                foreach (int number in numbers)
                {
                    listView2.Items.Add(number.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //close app
            this.Close();
        }
    }
}
