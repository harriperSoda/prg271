using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise_3
{
    internal class Employee:Person
    {
        public DateTime hireDate {  get; set; }
        public string idNumber {  get; set; }

        public Employee(string n, int a, DateTime hd, string id):base(n,a)
        {
            hireDate = hd;
            idNumber = id;
        }

        public override void displayDetails()
        {
            Console.WriteLine($"Name:{name}, Age:{age}, i was hired on {hireDate:d} and my id number is {idNumber}");
        }
    }
}
