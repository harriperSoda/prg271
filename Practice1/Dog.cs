using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    //we have created the class. The class is a blueprint for creating objects. The class contains fields, properties, methods, and events. In this case, we have created a class called Dog that contains four public fields: name, age, height, and weight.

    //The fields are used to store the data of the object. The fields are public, which means they can be accessed from outside the class.

    //objects are created in the main method of the program.
    internal class Dog
    {

        //Declaring public fields
        public string name;
        public int age;
        public double height, weight;

        //This a constructor
        //it accepts arguments when the object is is instantianted and assigns them to the fields


        public Dog(string dogName, int dogAge, double dogHeight, double dogWeight)
        // WARNING: 'age = age;' causes Variable Shadowing!
        // The computer gets confused and assigns the incoming parameter back to itself.
        // The class's actual 'age' field remains unassigned (0).
        {
            name = dogName;
            age = dogAge;   
            height = dogHeight; 
            weight = dogWeight;


        }
    }
}
