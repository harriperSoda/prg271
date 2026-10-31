using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrac_Rescue
{
    internal class MountainR
    {
        public static void PerformRescue()
        {
            Console.WriteLine("Water Unit started rescue...");
            Thread.Sleep(2000);
            Console.WriteLine("Water Unit completed rescue.");
        }
    }
}
