using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Practice
{
    internal class Dish
    {
        //MADE THIS A PROPETY INSTEAD
        //public string dishName;
        //public string dishCategory;
        //public double prepareTime;
        //public string difficulty;
        //public string assignedContestant;
        //public string kitchenStation;

        public string dishName { get; set; }
        public string dishCategory { get; set; }
        public double prepareTime { get; set; }
        public string difficulty { get; set; }
        public string assignedContestant { get; set; }
        public string kitchenStation { get; set; }

        public Dish(string dishName, string dishCategory, double prepareTime, string difficulty, string assignedContestant, string kitchenStation) 
        { 

            //"this.dishName points to the class level variables, declared on top
            this.dishName = dishName; //the dishName on the right points to the parameter passed in the constructor. THEY MUST MATCH
            this.dishCategory = dishCategory;
            this.prepareTime = prepareTime;
            this.difficulty = difficulty;
            this.assignedContestant = assignedContestant;
            this.kitchenStation = kitchenStation;
        }

    }

}