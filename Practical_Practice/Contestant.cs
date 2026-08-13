using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Practice
{
    
        //creation of general/asbtract classes - child classes will inherit from this class

        public abstract class Contestant
        {
            public int contestantNumber { get; set; }
            public string contestantName { get; set; }
            public int contestantAge { get; set; }
            public int yearsOfExperience { get; set; }
            public string team { get; set; }

            //constructor
            public Contestant(int contestantNumber, string contestantName, int contestantAge, int yearsOfExperience, string team)
            {
                this.contestantNumber = contestantNumber;
                this.contestantName = contestantName;
                this.contestantAge = contestantAge;
                this.yearsOfExperience = yearsOfExperience;
                this.team = team;

            }

        //create abstract method
        public abstract void prepareDish();
        }
    }

        

