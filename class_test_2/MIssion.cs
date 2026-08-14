using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_2
{
    internal class MIssion
    {

        public int missionID { get; set; }
        public string missionNAme { get; set; }
        public string location { get; set; }
        public int dangerLevel { get; set; }
        public int completionStatus { get; set; }

        public MIssion(int missionID, string missionName, string location, int dangerLevel, int completionStatus)
        {
            this.missionID = missionID;
            this.missionNAme = missionNAme;
            this.location = location;
            this.dangerLevel = dangerLevel;
            this.completionStatus = completionStatus;
        }
    }
}
