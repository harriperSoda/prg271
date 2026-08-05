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
            Dog myDog = new Dog("Sparky",4,0.6,12.5);
            //just add values in here
            //The class Dog is the blueprint - it defines what it should look like: name etc
            //Dog myDog... is the consutrction.
            //see readme for more information on this Point 1

            //call the status method to print out the current status of the dog
            myDog.currentStatus();
            Console.ReadLine();

        }
    }
}
