using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Lec5_Ex1
{
    internal class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Job { get; set; }

        public Person(string name, string surname, string job)
        {
            this.Name = name;
            this.Surname = surname;
            this.Job = job;
        }
    }
}
