using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Lec5_Ex2
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }

        public Person(string name, string surname, DateTime dOB)
        {
            this.Name = name;
            this.Surname = surname;
            this.DOB = dOB;
        }    }
}
