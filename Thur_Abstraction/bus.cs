using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thur_Abstraction
{
    internal class bus : Vechile
    {
        public bus(int w) : base(w)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"{wheels} bus");
        }
    }
}
