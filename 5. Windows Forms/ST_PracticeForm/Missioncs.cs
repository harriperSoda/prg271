using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_PracticeForm
{
    internal class Missioncs
    {

        //propeties
        public string MissionName { get; set; }
        public string Status { get; set; }

        //constructor
        public Missioncs(string MissionName, string Status)
        {
            this.Status = Status;
            this.MissionName = MissionName;
        }
    }
}
