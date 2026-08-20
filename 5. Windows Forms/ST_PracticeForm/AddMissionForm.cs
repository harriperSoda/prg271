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
    public partial class AddMissionForm : Form
    {
        private MissionDataHandler missionDataHandler;

        public AddMissionForm() : this(new MissionDataHandler())
        {
        }

        internal AddMissionForm(MissionDataHandler missionDataHandler)
        {
            InitializeComponent();
            this.missionDataHandler = missionDataHandler;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Missioncs thisMission = new Missioncs(
            textBoxMission.Text, comboBoxStatus.Text);
            missionDataHandler.AddMission(thisMission);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxMission_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddMissionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
