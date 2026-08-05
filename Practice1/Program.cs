using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            //The class Dog is the blueprint - it defines what it should look like: name etc
            //Dog myDog... is the consutrction.
            //see readme for more information on this Point 1
            
            //Initilization of values to all fields in Dog class
            myDog.name = "Fido";
            myDog.age = 3;
            myDog.height = 0.5;
            myDog.weight = 20.0;

            // Follows the object reference in memory and runs the method using that specific object's data
            myDog.currentStatus();
        }
    }
}
