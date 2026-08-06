using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thur_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Bread", 23.00, 3);
            Product product2 = new Product("Protein Powder", 399.00, 1);

            Console.WriteLine("Method Overloading");
            Console.WriteLine("================================");

            //invoke CalcualteTotal Method
            Console.WriteLine($"Total using stored quanity: R{product1.CalculateTotal(5)}");

            //CalculateTotal(int quantity)
            Console.WriteLine($"Total for 5 loaves of bread: R{product1.CalculateTotal(5)}");

            //CalcualteTotal(2 parametres)
            Console.WriteLine($"The total for 5 loaves of bread with a 5% discount is: R{product1.CalculateTotal(5,5)}");

            Console.WriteLine();

            Console.WriteLine("ORIGINAL PRODUCTS\n");
    

            product1.displayDetails();
            product2.displayDetails();


            //opperator overloading
            Product combinedProduct = product1 + product2;
            Console.WriteLine("Combined Product");
            combinedProduct.displayDetails();

            Console.WriteLine("Polomorphism");

            Console.ReadLine();
        }
    }
}
