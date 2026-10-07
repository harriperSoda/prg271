using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class Legolas: Character
    {
        public string bowType { get; set;  }

        public Legolas(int id, string name, int age, int strengthLevel, string bowType): base(id, name, age, strengthLevel)
        {
            this.bowType = bowType;
        }

        public override void showCharacters()
        {
            Console.WriteLine($"Character ID: {id} called {name} is {age} years old, has a strength level of {strengthLevel} and a {bowType} weapon");
        }
    }
    
}
