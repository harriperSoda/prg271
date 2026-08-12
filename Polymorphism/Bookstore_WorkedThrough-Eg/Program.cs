using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_WorkedThrough_Eg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Instantiation: Building our book object
            Book book1 = new Book("The Great Gatsby", 10.99, 5);

            // 2. Testing Method Overloading

            // Calls Version A (0 inputs): Uses internal stock (3) -> 500 * 3
            double total1 = book1.CalculateTotal();
            Console.WriteLine($"Total using default stock levels; {total1}");

            // Calls Version B(1 input): Uses temporary quantity(10)-> 500 * 10
            double total2 = book1.CalculateTotal(10);
            Console.WriteLine($"Total using custom quantity of 10: {total2}");

            // Calls Version C (2 inputs): Uses quantity (5) and discount (20%) -> (500 * 5) - 20%
            double total3 = book1.CalculateTotal(5, 20);
            Console.WriteLine($"Total using custom quantity of 5 with 20% discount: {total3}");
        }
    }
}
