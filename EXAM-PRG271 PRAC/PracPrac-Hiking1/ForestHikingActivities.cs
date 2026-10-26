using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PracPrac_Hiking1
{
    internal class ForestHikingActivities
    {
        public static void ForestHike()
        {
            Console.WriteLine("Starting forest hiking");
            Thread.Sleep(5000);
            Console.WriteLine("Matt started a forest trail");
            Thread.Sleep(1000);
            Console.WriteLine("Matt gave up anf fucked off back");
        }
    }
}
