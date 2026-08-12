using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Events_Class2.Calc;

namespace Events_Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //create a class called calcilations
            //4 methods + - * /
            //4 delegates
            // invoke the methods inside your main method

            AddDelegate obj = new AddDelegate(Calc.Add);
            double result = obj(10, 5);
            Console.WriteLine("Addition: " + result);

            SubtractDelegate obj2 = new SubtractDelegate(Calc.Subtract);
            double result2 = obj2(10, 5);
            Console.WriteLine("Subtraction: " + result2);

            MultiplyDelegate obj3 = new MultiplyDelegate(Calc.Multiply);
            double result3 = obj3(10, 5);
            Console.WriteLine("Multiplication: " + result3);

            DivideDelegate obj4 = new DivideDelegate(Calc.Divide);
            Console.WriteLine("Division: " + obj4(10, 5));





            Console.ReadLine();

        }
    }
}
