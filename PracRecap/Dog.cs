using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracRecap
{
    internal class Dog: Pet
    {
        public Dog(int petID, string name, int age): base(petID, name, age)
        {

        }

        public override void PetInfo()
        {
            Console.WriteLine($"{name}, with ID {petID}, says Woof Woof of {age} years old  ");
        }
    }
}
