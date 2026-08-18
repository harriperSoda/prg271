using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassForm
{
    abstract class Vehicles
    {

        //Fields
        string name;
        string type;
        double distance;
        double price;

        public string Name { get { return name; } }
        public string Type { get { return type; } }
        public double Distance { get { return distance; } }
        public double Price { get { return price; } }


        //CONSTRUCTOR
        public Vehicles(string name, string type, double distance, double price)
        {
            this.name = name;
            this.type = type;
            this.distance = distance;
            this.price = price;
        }

        //ToString method
        public override string ToString()
        {
            return string.Format("Name: {0}\tType: {1}\tDistance: {2}\tPrice: {3}", name, type, distance, price);
        }

    }
}
