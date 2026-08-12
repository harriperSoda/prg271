using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_FirstPracticeRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. INSTANTIATION (CREATING AN OBJECT)
            // We are taking our 'Dog' blueprint (the class) and building a real dog object in memory.
            Dog dog1 = new Dog("Fido", 3);

            // 2. USING THE OBJECT (ACCESSING DATA)
            // We access the data (name and age) stored inside our specific dog object and print it.
            Console.WriteLine($"Dog's Name: {dog1.name}");
            Console.WriteLine($"Dog's Age: {dog1.age}");

        }
    }
}
