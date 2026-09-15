using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class Gollum: Character
    {
        public string caveLocation { get; set; }

        public Gollum(int id, string name, int age, int strengthLevel, string caveLocation): base(id, name, age, strengthLevel)
        {
            this.caveLocation = caveLocation;
        }

        public override void callCharacter()
        {
            Console.WriteLine($"Character ID: {id} called {name} is {age} years old, has a strength level of {strengthLevel} and a {caveLocation} house");
        }
    }
}
