using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee is the class. employee1 is the object. new Employee() is the constructor. The parameters are passed in to initialize the properties of the Employee object.
            Employee employee1 = new Employee(30, "John Doe", new DateTime(2020, 5, 15), "EMP12345");

            // Call the DisplayInfo method to show the employee's information
            employee1.DisplayInfo();
        }
    }
}
