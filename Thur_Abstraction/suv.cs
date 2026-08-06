using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thur_Abstraction
{
    internal class suv: Vechile
    {
        string type;

        public suv(int w, string t): base(w)
        {
            type = t;
        }
        public override void Display()
        {
            Console.WriteLine($"{wheels} {type}");

        }
    }
}
