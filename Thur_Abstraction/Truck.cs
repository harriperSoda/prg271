using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thur_Abstraction
{
    internal class Truck: Vechile 
    {
        int doors;

        public Truck(int w, int d): base(w)
        {
            doors = d;
        }
        
        public override void Display()
        {
            Console.WriteLine($"{wheels} {doors}");
        }
    }
}
