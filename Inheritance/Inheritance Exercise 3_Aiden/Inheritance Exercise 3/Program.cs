using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polit name = new Polit("aden jansen", 100, new DateTime(2020,2,16),"603", new DateTime(2023,1,23));
            Customer customer = new Customer("Jordan Laio", 57, "LOW52AJ");
            Aircraft aircraft = new Aircraft("Jasmine Hnery", 23, new DateTime(2025, 03, 26), "KKK245KK", "KAH-DHF", "6522515");

            Console.WriteLine($"Pilot information:");
            Console.WriteLine("===========================");
            name.displayDetails();
            Console.WriteLine();
            customer.displayDetails();
            Console.WriteLine();
            aircraft.displayDetails();
            Console.ReadLine();
        }
    }
}
