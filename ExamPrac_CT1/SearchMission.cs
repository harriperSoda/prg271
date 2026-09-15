using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class SearchMission: Mission
    {
        public SearchMission(int missionId, string name, string location, int dangerLevel, string completionStatus): base(missionId, name, location, dangerLevel, completionStatus) { 

        }

        public override void startMission()
        {
            Console.WriteLine($"Starting search mission at {location}");
        }
    }
}
