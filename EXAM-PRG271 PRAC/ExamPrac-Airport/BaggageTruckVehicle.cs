using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Airport
{
    internal class BaggageTruckVehicle: GroundVehicles
    {
        public int LoadCapacity { get; set; }

       public BaggageTruckVehicle(int vehicleID, string vehicleName, int vehicleFuelLevel, int vehicleMaxSpeed, int LoadCpacity): base(vehicleID, vehicleName, vehicleFuelLevel, vehicleMaxSpeed)
        {
            this.LoadCapacity = LoadCapacity;
        }

        public override void ShowVehicle()
        {
            Console.WriteLine("Vehicle type: Baggage Truck");
            Console.WriteLine($"Vehicle ID: {VehicleID}");
            Console.WriteLine($"Vehicle Name: {VehicleName}");
            Console.WriteLine($"Vehicle Fuel Level: {VehicleFuelLevel}");
            Console.WriteLine($"Vehicle Max Speed: {VehicleMaxSpeed}");
            Console.WriteLine($"Vehicle Load Capacity: {LoadCapacity}");
        }
    }
}
