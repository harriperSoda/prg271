using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal abstract class Mission
    {
        public int missionId { get; set; }
        public string name { get; set; }
        public string location { get; set; }    
        public int dangerLevel { get; set; }
        public string completionStatus { get; set; }

        public Mission(int missionID, string name, string location,  int dangerLevel, string completionStatus)
        {
            this.missionId = missionID;
            this.name = name;
            this.location = location;
            this.dangerLevel = dangerLevel;
            this.completionStatus = completionStatus;
        }

        public abstract void startMission();
    }
}
