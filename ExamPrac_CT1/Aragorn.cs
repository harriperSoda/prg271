using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class Aragorn: Character
    {

        public string weapon { get; set; }

        public Aragorn(int id, string name, int age, int strengthLevel, string weapon): base(id, name, age, strengthLevel)
        {
            this.weapon = weapon;
        }

        public override void callCharacter()
        {
            Console.WriteLine($"Character ID: {id} called {name} is {age} years old, has a strength level of {strengthLevel} and a {weapon} weapon");
        }
        
    }
}
