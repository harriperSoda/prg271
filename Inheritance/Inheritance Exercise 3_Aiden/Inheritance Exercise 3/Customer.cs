using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise_3
{
    internal class Customer:Person
    {
        public string loyaltyNumber {  get; set; }
        
        public Customer(string n, int a, string ln):base(n,a) 
        { 
            loyaltyNumber = ln;
        }

        public override void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine($"loyalty number: {loyaltyNumber}");
        }
    }
}
