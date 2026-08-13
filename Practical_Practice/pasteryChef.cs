using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Practice
{

    //Here we create the child class that inherits from the abstract class. We specify the inheritance, create the constructor, and mention the base so that it can reffer the given values back to base. And we specifiy the override
    internal class pasteryChef: Contestant
    {

        //constructor catches data from main
        public pasteryChef(int contestantNumber, string contestantName, int contestantAge, int yearsOfExperience, string team) : base(contestantNumber, contestantName, contestantAge, yearsOfExperience, team)
        {

        }

        //Override the abstract method from the parent class
        public override void prepareDish()
        {
            Console.WriteLine($"{contestantName} is preparing a dessert dish.");
        }

    }
}
