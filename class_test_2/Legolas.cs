using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_2
{
    internal class Legolas: Character
    {
        public Legolas(int characterID, string name, int age, int strengthLevel) : base(characterID, name, age, strengthLevel)
        {

        }

        public override void SummonCharacter()
        {
            Console.WriteLine($"Character ID: {characterID}, Name: {name}, Age: {age}, Strength Level: {strengthLevel} has a unique bow ");
        }
    }
}
