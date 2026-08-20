using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PracticeForm
{
    public partial class FormCrew : Form
    {
        //need to create an instance of the CrewDataHandler class to access the crew members
        private CrewDataHandler crewHandler = new CrewDataHandler();
        public FormCrew()
        {
            InitializeComponent();
        }

        private void labelCrewHeading_Click(object sender, EventArgs e)
        {

        }

        private void FormCrew_Load(object sender, EventArgs e)
        {
            //run the method to populate the crew members list
            crewHandler.PopulateCrew();
            //Show the list in the DataGridView
            dataGridViewCrewTable.DataSource = crewHandler.getCrewMemebrs();

        }
    }
}
