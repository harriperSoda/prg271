using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class Threat
    {
        public int threatId { get; set;  }
        public string name { get; set; }
        public string location { get; set; }
        public int dangerLevel { get; set; }

        public Threat(int threatId, string name,  string location, int dangerLevel)
        {

            if (dangerLevel < 1 || dangerLevel > 10)
            {
                throw new InvalidDangerLevelException( //creates object of custom exception class created. Throw means raise the error
                    //passes the text below as the asrugment into the constructor in the class
                    "danger level must be between 1 and 10"
                    );
            }

            this.threatId = threatId;
            this.name = name;
            this.location = location;
            this.dangerLevel = dangerLevel;
        }
    }
}
