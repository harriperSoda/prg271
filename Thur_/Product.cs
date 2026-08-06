using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thur_
{
    internal class Product
    {
        public string name;
        public double price;
        public int quanity;

        public Product(string name, double price, int quanity)
        {
            //


        }
        //method 1
        public double CalculateTotal()
        {
            return price * quanity;
        }
        //method 2
        public double CalculateTotal(int quantity)
        {
            return price * quantity;
        }
        //method 3
        public double CalculateTotal(int quantity, double discountPercentage)
        {
            double subTotal = price * quantity;
            double discountAmount = subTotal * (discountPercentage / 100);
            return subTotal - discountAmount;
        }

        //opperator overload
        public static Product operator +(Product Product1, Product Product2)
        {
            int combinedQuantity = Product1.quanity + Product2.quanity;
            double combinedTotalPrice = Product1.CalculateTotal() + Product2.CalculateTotal();
            double combinedUnitPrice = combinedQuantity > 0? combinedTotalPrice / combinedQuantity : 0;

            string combinedName = Product1.name + Product2.name;
            return new Product(combinedName, combinedUnitPrice, combinedQuantity);
        }
        public void displayDetails()
        {
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Unit Price: {price}");
            Console.WriteLine($"Quantity: {quanity}");
            Console.WriteLine($"Total Price: {CalculateTotal()}");
        }
    }
}

    
