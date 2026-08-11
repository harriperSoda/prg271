using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise3
{
    internal class Person
    {
        //Declare our propeties 
        public double age { get; set; }
        public string name { get; set; }

        //create the contructor for the Person class
        public Person(double age, string name) //age and name here are not based of the above declared - they can be named anything
        {
            this.age = age;
            this.name = name;

            //function of this: set the class propety age to the value of the age parameter passed into the constructor. Same for name.
        }

        public virtual void DisplayInfo() //virtual gives child classes to overwrite this method
            //could instead return something different
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

    }
}
