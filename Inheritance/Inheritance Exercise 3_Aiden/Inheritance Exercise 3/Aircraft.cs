using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise_3
{
    internal class Aircraft:Equipment
    {
        public string type {  get; set; }
        public string tailNum {  get; set; }

        public Aircraft(string n, int a, DateTime aq, string pd, string t, string tnum) : base(n, a, aq, pd)
        {
            type = t;
            tailNum = tnum;
        }

        public override void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine($"Type: {type}, tail number: {tailNum}");
        }
    }
}
