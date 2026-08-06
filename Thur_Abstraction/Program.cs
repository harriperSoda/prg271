
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thur_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            suv suv = new suv(4, "SUV");
            suv.Display();

            bus bus = new bus(6);
            bus.Display();

            Truck truck = new Truck(8, 2);
            truck.Display();

            Console.ReadLine();
        }
    }
}
