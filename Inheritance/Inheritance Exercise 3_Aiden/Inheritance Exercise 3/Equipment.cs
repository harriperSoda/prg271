using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise_3
{
    internal class Equipment:Person
    {
        public DateTime aquireDate {  get; set;}
        public string PropertyID {  get; set;}
        
        public Equipment(string n, int a, DateTime aq, string pd):base(n,a)
        {
            aquireDate  = aq;
            PropertyID = pd;
        }

        public override void displayDetails()
        {
            
            Console.WriteLine($"Aquire date: {aquireDate}, property: {PropertyID}");
        }
    }
}
