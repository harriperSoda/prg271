using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tue_BankApplic
{
    internal class BankAccount
    {
        //private field not accesible from outside
        private double balance;

        public BankAccount(double initialBalance)
        {
            if (initialBalance >= 0)
            {
                balance = initialBalance;
            }
            else
            {

            }
        }
    }
}
