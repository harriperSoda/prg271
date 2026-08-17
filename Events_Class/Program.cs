using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Events_Class.myMethods;

namespace Events_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DelegateMethod delPrint = myMethods.printMethod;
            //delPrint();

            //DelegateMath delMath = myMethods.MathMethod;
            //double answer = delMath(10, 7);
            //Console.WriteLine($"The answer is: {answer}");
            //myMethods myM = new myMethods();

            //DelegateMethod delPrint = new DelegateMethod(myM.printMethod);
            //delPrint();
            //DelegateMath delMath = new DelegateMath(myM.MathMethod);
            //double answer = delMath(10, 7);
            //Console.WriteLine($"The answer is: {answer}");


            DelegateMath delMath = new DelegateMath(myMethods.MathMethod);
            double answer = delMath(10, 7);
            Console.WriteLine($"The answer is: {answer}");
        }
    }
}
