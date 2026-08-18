using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassForm
{
    internal class DataHandler
    {
        //Method to return a populated list
        public List<Vehicles> GetVehicles()
        {
            List<Vehicles> allVehicles = new List<Vehicles>();

            //opulate
            allVehicles.Add(new Busses("Volvo", "Bus", 100, 50000));
            allVehicles.Add(new Busses("Mercedes", "Bus", 200, 60000));
            allVehicles.Add(new Cars("Toyota", "Car", 50, 20000));
            allVehicles.Add(new Cars("Honda", "Car", 75, 25000));

            //return the list
            return allVehicles;
        }
    }
}
