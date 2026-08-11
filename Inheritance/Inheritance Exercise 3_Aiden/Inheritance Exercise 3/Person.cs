using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise_3
{
    internal class Person
    {
        protected string name {  get; set; }
        protected int age { get; set; }

        public Person(string n, int a)
        {
            name = n;
            age = a;
        }

        public virtual void displayDetails()
        {
            Console.WriteLine($"Name:{name}, Age:{age}");
        }
    }
}
