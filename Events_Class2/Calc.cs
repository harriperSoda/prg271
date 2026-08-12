using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Class2
{
    internal class Calc
    {
        public static double Add(int a, int b)
        {
            return a + b;
        }
        public static double Subtract(int a, int b)
        {
            return a - b;
        }
        public static double Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
        }

        //4 delegates
        public delegate double AddDelegate(int a, int b);
        public delegate double SubtractDelegate(int a, int b);
        public delegate double MultiplyDelegate(int a, int b);
        public delegate double DivideDelegate(int a, int b);
    }
}
