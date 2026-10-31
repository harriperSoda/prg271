using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Rescue
{
    internal abstract class RescueUnit
    {
        public int UnitID { get; private set; } 
        public string UnitName { get; set; }
        public int CrewSize { get; set; }
        public int ReadyLevel { get; set; }

        //constructor
        public RescueUnit(int unitID, string unitName, int crewSize, int readyLevel)
        {
            this.UnitID = unitID;
            this.UnitName = unitName;
            this.CrewSize = crewSize;
            this.ReadyLevel = readyLevel;
        }

        public abstract void DisplayUnits();
      
        
    }
}
