using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Practice
{
    internal class PastryChef: Contestant
    {

        //constructor
        public PastryChef(int contestantNumber, string contestantName, int contestantAge, int yearsOfExperience, string team) : base(contestantNumber, contestantName, contestantAge, yearsOfExperience, team)
        {
        }

        //override
        public override void prepareDish()
        {
            Console.WriteLine($"{contestantName} is preparing a pastry dish.");
        }
    }
}
