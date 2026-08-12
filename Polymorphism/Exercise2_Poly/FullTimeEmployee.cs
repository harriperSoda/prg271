using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Poly
{
    internal class FullTimeEmployee:Employee
    {
       public double salary { get; set; }

        public override void CalculateSalary()
        {
            Console.WriteLine($"Calculating salary for FullTimeEmployee: {salary}");
        }
        
    }
}
