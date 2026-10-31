using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrac_Airport
{
    class GroundOppFuelTruck
    {
        public static void FuelTruckStart()
        {
            Console.WriteLine("Fuel Truck started refuelling aircraft...");
            Thread.Sleep(2000);
            Console.WriteLine("Fuel Truck finished.");

		}
    }
}
