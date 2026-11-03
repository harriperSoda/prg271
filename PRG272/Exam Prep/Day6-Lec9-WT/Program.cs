using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Lec9_WT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataHandler handler = new DataHandler();
            //handler.GetCategories();
            //handler.InsertData();
            //handler.UpdateData();
            //handler.DeleteData();
            handler.GetSingularValue();
            Console.ReadLine();
        }
    }
}
