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

        public override void showMission()
        {
            Console.WriteLine($"You are engaging in a combat mission at {location}");
            Console.WriteLine($"Mission ID: {missionId}");
            Console.WriteLine($"Mission Name: {name}");
            Console.WriteLine($"Mission Danger Level: {dangerLevel}");
            Console.WriteLine($"Mission Completion Status: {completionStatus}");
        }

        public override void startMission()
        {
            if (completionStatus == "complete")
            {
                throw new MissionAlreadyCompletedException("This mission is already complete");
            }
            Console.WriteLine($"Starting combat mission: {name} at {location}");
        }
    }
}
