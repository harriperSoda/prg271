using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise_3
{
    internal class Polit:Employee
    {
        public DateTime certificationDate {  get; set; }
        public Polit(string n, int a, DateTime hd, string id, DateTime cd):base(n, a, hd, id)
        {
            certificationDate = cd;
        }

        public override void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine($"Certifaction date: {certificationDate}");
        }
    }
}
