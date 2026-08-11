using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise3
{
    internal class Customer: Person
    {
        public string loyaltyNumber { get;set; }

        public Customer(double age, string name, string loyaltyNumber):base(age, name)
        {
            this.loyaltyNumber = loyaltyNumber;
        }
    }
}
