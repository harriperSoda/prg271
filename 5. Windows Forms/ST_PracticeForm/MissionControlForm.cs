using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PracticeForm
{
    public partial class MissionControlForm : Form
    {
        //instantate the MissionDataHandler class to access the mission data
        MissionDataHandler missionHandler = new MissionDataHandler();

        public MissionControlForm()
        {
            InitializeComponent();
        }

        private void MissionControlForm_Load(object sender, EventArgs e)
        {
            //run the method to populate the mission list
            missionHandler.PopulateMission();
            //show list in the DataGridView
            dataGridViewMissions.DataSource = missionHandler.getMissions();
        }

        private void buttonBackMissionControl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
