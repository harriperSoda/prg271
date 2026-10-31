using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrac_Rescue
{
    internal class MountainRescueUnit: RescueUnit
    {
        //declare its own propety
        public int ClimbingGearCount { get; set; }

        //constructor that expects the normal values + the clibming gear and we pass shared propeties to parent class
        public MountainRescueUnit(int unitID, string unitName, int crewSize, int readyLevel, int climbingGearCount): base (unitID, unitName, crewSize, readyLevel)
        {
            this.ClimbingGearCount = climbingGearCount;
        }

        public override void DisplayUnits()
        {
            Console.WriteLine($"Mountain Rescue ID: {UnitID}");
            Console.WriteLine($"Unit Name: {UnitName}");
            Console.WriteLine($"Crew Size: {CrewSize}");
            Console.WriteLine($"Readiness Level: {ReadyLevel}");
            Console.WriteLine($"Climbing Gear Count: {ClimbingGearCount}");
        }

        
    }
}
