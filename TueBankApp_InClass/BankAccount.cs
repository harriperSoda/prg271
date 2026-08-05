using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TueBankApp_InClass
{
    internal class BankAccount
    {

        private string accountHolder;
        private double balance;

        //constructor - takes name of class as method
        public BankAccount(string ah, double b)
        {
            //need to sue propeties and methods so that we can validate the data
            accountHolder = ah;
            if (b < 0) //variabkes are taken from above
            {
                throw new ArgumentException("Balance cannot be zero");
            }
            balance = b;
        }
        //public data members with controled access
        public string AccountHolder
        {
            get
            {
                return accountHolder;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Account holder name cannot be empty");
                }
                accountHolder = value.Trim();
            }
        }
        //balance can be read from outside the class bnit it can not bne asigned directly
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        //public methods that changes the balance
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");


            }
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");

        }
        //public methods to validate withdrawls
        public bool Withdrawl(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawl failed: Amount must be positive.");
                return false;
            }
            if (amount > balance)
            {
                Console.WriteLine("Withdrawl failed: Insufficient funds.");
                return false;
            }
            balance -= amount;
            Console.WriteLine($"Withdrawl successful: {amount}");
            return true;
        }
        //need public method that displays the account information
        public void DislayAccountDetails()
        {
            Console.WriteLine("\nAccount Detaisl:");
            Console.WriteLine("======================");
            Console.WriteLine($"Account Holder: {accountHolder}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}

