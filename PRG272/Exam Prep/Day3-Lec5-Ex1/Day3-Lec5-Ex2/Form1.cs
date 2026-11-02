using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3_Lec5_Ex2
{
    public partial class Form1 : Form
    {
        List<Person> person = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void buttonToList_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            DateTime dOB = dateTimePicker1.Value.Date;

            if (!Validator.ValidateNameSurname(name))
            {
                MessageBox.Show("Recheck the name you entered");
                return;
            }
            if (!Validator.ValidateNameSurname(surname))
            {
                MessageBox.Show("Recheck the name you entered");
                return;

            }
            if (!Validator.ValidateDOB(dOB))
            {
                MessageBox.Show("Date cant be past today");
                return;
            }

            Person newPerson = new Person(name, surname, dOB);

            person.Add(newPerson);
            string formatedPerson = $"{newPerson.Name}; {newPerson.Surname}; {newPerson.DOB}";
            listView1.Items.Add(formatedPerson);


        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                DataHandler.AddToFile(person);
                MessageBox.Show("Added");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<string> AllPeople = DataHandler.ReadData();

            foreach (string person in AllPeople)
            {
                listView1.Items.Add(person);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

