using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class RescueMission: Mission
    {
        public string missionTypeRescue { get; set; }
        public RescueMission(int missionId, string name, string location, int dangerLevel, string completionStatus): base(missionId, name, location, dangerLevel, completionStatus)
        {
            this.missionTypeRescue = "Rescue";
        }

        public override void startMission()
        {
            if (completionStatus == "complete")
            {
                throw new MissionAlreadyCompletedException("This mission is already complete");
            }

            Console.WriteLine($"Starting search mission: {name} at {location}");
        }

        public override void showMission()
        {
            Console.WriteLine($"You are engaging in a search mission at {location}");
            Console.WriteLine($"Mission ID: {missionId}");
            Console.WriteLine($"Mission Name: {name}");
            Console.WriteLine($"Mission Danger Level: {dangerLevel}");
            Console.WriteLine($"Mission Completion Status: {completionStatus}");
        }
    }
}
