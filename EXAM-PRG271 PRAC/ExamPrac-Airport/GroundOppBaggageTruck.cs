using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrac_Airport
{
    internal class GroundOppBaggageTruck
    {

        public static void BaggageTruckStart()
        {
            Console.WriteLine("Baggage Truck started transporting luggage...");
            Thread.Sleep(5000);
            Console.WriteLine("Baggage Truck finished transporting luggage.");
        }
    }
}
