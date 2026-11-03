using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Lec9_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataHandler handler = new DataHandler();
            handler.AddNewRow();
            handler.UpdateId3();
            handler.DeleteRow();
            handler.RowCount();
        }
    }
}
