using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class Gandalf: Character
    {
        public string staffType { get; set;  }

        public Gandalf(int id, string name, int age, int strengthLevel, string staffType): base(id, name, age, strengthLevel)
        {
            this.staffType = staffType;
        }

        public override void showCharacters()
            //override as it provides its own behaviour
        {
            Console.WriteLine($"Character ID: {id} called {name} is {age} years old, has a strength level of {strengthLevel} and a {staffType} weapon");
        }
    }
}
