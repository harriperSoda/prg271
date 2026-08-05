using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TueBankApp_InClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount account = new BankAccount("Vishin", 1000);
                account.DislayAccountDetails();
                account.Deposit(500);
                account.Withdrawl(200);
                Console.WriteLine();
                account.Withdrawl(2000); // This will throw an exception
                account.Deposit(-100); // This will also throw an exception


            }
            catch (ArgumentException exception)
            {
                Console.WriteLine($"Error: {exception.Message}");
            }
            Console.ReadLine();
        }
    }
    }

