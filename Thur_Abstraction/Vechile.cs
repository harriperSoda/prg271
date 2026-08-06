using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thur_Abstraction
{
    internal class Vechile
    {
        protected int wheels;

        public Vechile(int w)
        {
            this.wheels = w;
        }
        public abstract void Display();
    }
}
