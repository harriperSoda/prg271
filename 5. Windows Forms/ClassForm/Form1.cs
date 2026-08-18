using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //create object of the source
        BindingSource src = new BindingSource();
        List<Vehicles> myVehicle = new List<Vehicles>();

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //object to access data handler class
            DataHandler handler = new DataHandler();

            myVehicle = handler.GetVehicles();

            //set our source data
            src.DataSource = myVehicle;

            //bind data source to dataGridView
            dataGridView1.DataSource = src;
        }

        private void buttonAllVech_Click(object sender, EventArgs e)
        {
            //set source of data
            src.DataSource = myVehicle;

            //Bind data source to dataGridView
            dataGridView1.DataSource = src;
        }

        private void buttonBusses_Click(object sender, EventArgs e)
        {
            //create new list to hold busses
            List<Busses> busList = new List<Busses>();

            //loop and check for busses in myVehicle list

            foreach(Vehicles item in myVehicle)
            {
                if(item is Busses){
                    busList.Add((Busses)item);
                }
            }
            src.DataSource = busList;
        }

      

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchInput = textBoxSearch.Text;
            bool found = false;

            foreach(Vehicles item in myVehicle)
            {
                if(item.Name = searchInput)
                {
                    found = true;
                }
            }
        }
    }
}
