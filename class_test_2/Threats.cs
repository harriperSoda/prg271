using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_2
{
    internal class Threats
    {

        public int threatID { get; set; }
        public string threatName { get; set; }
        public string threatLocation { get; set;  }
        public int dangerLevel { get; set; }

        public Threats(int threatID, string threatName, string threatLocation, int dangerLevel)
        {
            this.threatID = threatID;
            this.threatName = threatName;
            this.threatLocation = threatLocation;
            this.dangerLevel = dangerLevel;
        }

        public void ShowThreat()
        {
            Console.WriteLine($"Thread with ID, {threatID} and name, {threatName} at {threatLocation} has a danger level of {dangerLevel}}");
        }
    }
}
