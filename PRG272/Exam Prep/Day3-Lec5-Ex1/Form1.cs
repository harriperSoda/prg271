using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3_Lec5_Ex1
{
    
    public partial class Form1 : Form
    {
        List<Person> person = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddToList_Click(object sender, EventArgs e)
        {
            

            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string job = textBoxJob.Text;

            if (!Validation.ValidateName(name))
            {
                MessageBox.Show("Enter a proper name");
                return;
            }
            if (!Validation.ValidateSurname(surname))
            {
                MessageBox.Show("Enter a proper surname");
                return;
            }
            if (!Validation.ValidateJob(job))
            {
                MessageBox.Show("Enter a correct surname");
                return;
            }


            Person newPerson = new Person(name, surname, job);

            person.Add(newPerson);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataHandler.SaveToFile(person);
                MessageBox.Show("Added to file");

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            List<string> lines = DataHandler.ReadFromFile();

            foreach(string line in lines)
            {
                listView1.Items.Add(line);
            }
        }
    }
}
