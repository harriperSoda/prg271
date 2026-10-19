using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataHandler handeler = new DataHandler();
            handeler.getCategories();
            //handeler.insertData();
            //handeler.updateCategory();
            //handeler.DeleteCategory();
            handeler.getSingleValue();

            Console.ReadLine();
        }
    }
    }

