using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Class
{
    internal class myMethods
    {
        public static void printMethod()
        {
            Console.WriteLine("From print method");
        }

        public static double MathMethod(double num1, double num2)
        {
            return num1 + num2;
        }

        public delegate void DelegateMethod();
        public delegate double DelegateMath(double num1, double num2);
    }
}
