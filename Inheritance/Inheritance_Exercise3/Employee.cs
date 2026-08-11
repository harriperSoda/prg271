using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise3
{
    internal class Employee:Person
    {
        public DateTime dateHired { get; set; }
        public string idNumber { get; set; }

        public Employee(double age, string name, DateTime dateHired, string idNumber):base(age, name)
        //base (age, name) calls the constructor of the base class (Person) to initialize the age and name properties inherited from Person. This ensures that when an Employee object is created, it also properly initializes the properties defined in the Person class.
        {
            this.dateHired = dateHired;
            this.idNumber = idNumber;
        }
    }
}
