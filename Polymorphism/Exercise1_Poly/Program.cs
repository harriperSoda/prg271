using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Create an array of type 'Animal' (the base class)
            Animal[] myAnimals = new Animal[2];

            // 5. Store different derived animal objects in the array
            myAnimals[0] = new Dog();
            myAnimals[1] = new Cat();

            Console.WriteLine("Iterating through the animal array:\n");

            // 6. Iterate through the array and call MakeSound()
            foreach (Animal currentAnimal in myAnimals)
            {
                // Even though currentAnimal is treated as an 'Animal', 
                // C# knows if it's actually a Dog or Cat and runs the correct method!
                currentAnimal.MakeSound();
            }

            Console.ReadLine();
        }
    }
}
