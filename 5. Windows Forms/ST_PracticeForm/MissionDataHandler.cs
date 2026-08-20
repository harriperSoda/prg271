using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_PracticeForm
{
    internal class MissionDataHandler
    {

        //creationj of list
        private List<Missioncs> MissionList = new List<Missioncs>();


        //method to add data to the list
        public void PopulateMission()
        {
            MissionList.Add(new Missioncs("Mission 1", "In progress"));
            MissionList.Add(new Missioncs("Mission 2", "Completed"));

        }

        //need to make the list accessible to the form so create a public method to return the list
        public List<Missioncs> getMissions()
        {
            return MissionList;
        }
    }
}
