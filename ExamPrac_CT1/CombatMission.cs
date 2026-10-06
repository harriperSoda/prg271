using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class CombatMission:Mission
    {
        public string missionTypeCombat { get; set; }
        public CombatMission(int missionId, string name, string location, int dangerLevel, string completionStatus): base(missionId, name, location, dangerLevel, completionStatus)
        {
            this.missionTypeCombat  = "Combat";
        }

        public override void startMission()
        {
            Console.WriteLine($"Starting combat mission at {location}");
        }
    }
}
