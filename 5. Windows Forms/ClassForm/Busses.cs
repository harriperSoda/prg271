using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassForm
{
    internal class Busses: Vehicles
    {

        public Busses(string name, string type, double distance, double price): base(name, type, distance, price)
        {

        }

        //ToString method
        public override string ToString()
        {
            return string.Format("{0]\t {1} \t {2} \t {3} \t,", Name, Type, Distance, Price);    
        }
    }
}
