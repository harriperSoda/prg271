using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_WorkedThrough_Eg
{
    internal class Book
    {
        // 1. Fields: The internal data variables every Book will own
        public string title;
        public double price;
        public int stock;

        // 2. Constructor: The assembly line that builds the book when 'new Book(...)' is called
        public Book(string title, double price, int stock)
        {
            this.title = title;
            this.price = price;
            this.stock = stock;
        }

        //METHOD 1: Calculates the total using the books own saved price and stock fields
        public double CalculateTotal()
        {
            return price * stock;
        }

        //METHOD 2: Custom quantity --> One parameter
        // It ignores the default stock and calculates the total for a temporary quantity passed in.
        public double CalculateTotal(int customQuantity)
        {
            return price * customQuantity;
        }

        // Method Version 3: TWO parameters (custom quantity + discount percentage)
        // It calculates the total for a custom amount and applies a percentage discount coupon.
        public double CalculateTotal(int customQuantity, double discountPercent)
        {
            double subTotal = price * customQuantity;
            double discountAmount = subTotal * (discountPercent / 100);
            return subTotal - discountAmount;
        }

    }
}
