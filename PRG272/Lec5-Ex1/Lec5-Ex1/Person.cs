using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5_Ex1
{
    internal class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string job { get; set; }

        public Person(string name, string surname, string job)
        {
            this.name = name;
            this.surname = surname;
            this.job = job;

        }
        public override string ToString() //provide the string representation of the object
        {
            return $"Name: {name}, Surname: {surname}, Job: {job}";
        }
    }
}
