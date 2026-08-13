using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantate
            FullTimeEmployee FTEmployee = new FullTimeEmployee();
            FTEmployee.salary = 50000;
            FTEmployee.CalculateSalary();

            PartTimeEmployees PTEmployee = new PartTimeEmployees(-5, 30);
            PTEmployee.CalculateSalary();


        }
    }
}
