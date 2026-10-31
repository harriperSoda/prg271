using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrac_Rescue
{
    internal class WaterRescueUnit: RescueUnit
    {
        public int BoatCapacity { get; set; }

        public WaterRescueUnit(int unitID, string unitName, int crewSize, int readyLevel, int boatCpacity): base(unitID, unitName, crewSize, readyLevel)
        {
            this.BoatCapacity = boatCpacity;
        }

        public override void DisplayUnits() //a public method that overrides the parents class use of it and void as it does not return a value
        {
            Console.WriteLine($"Mountain Rescue ID: {UnitID}");
            Console.WriteLine($"Unit Name: {UnitName}");
            Console.WriteLine($"Crew Size: {CrewSize}");
            Console.WriteLine($"Readiness Level: {ReadyLevel}");
            Console.WriteLine($"Boat Capacity: {BoatCapacity}");
        }
       
    }
}
