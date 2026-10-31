using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrac_Rescue
{
    internal class WaterR
    {
        public static void PerformRescue()
        {
            Console.WriteLine("Mountain Unit started rescue...");
            Thread.Sleep(5000);
            Console.WriteLine("Mountain Unit completed rescue.");
        }
    }
}
