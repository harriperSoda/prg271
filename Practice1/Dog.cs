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

        //Creation of a method called currentStatus that displays the current status of the dog. The method is public, which means it can be accessed from outside the class. The method does not return any value, so it is declared as void. The method uses the Console.WriteLine method to display the current status of the dog.
        public void currentStatus()
        {
            Console.WriteLine("{0} is {1} years old, {2} meters tall and weighs {3} kilograms.", name, age, height, weight);
        }
    }
}
