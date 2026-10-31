using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Airport
{
    internal class FuelTruckVehicle: GroundVehicles
    {
        public int FuelCapacity { get; set; }

        public FuelTruckVehicle(int vehicleID, string vehicleName, int vehicleFuelLevel, int vehicleMaxSpeed, int fuelCapacity): base(vehicleID, vehicleName, vehicleFuelLevel, vehicleMaxSpeed)
        {
            this.FuelCapacity = fuelCapacity;
        }
        public override void ShowVehicle()
        {
            Console.WriteLine("Vehicle type: Fuel Truck");
            Console.WriteLine($"Vehicle ID: {VehicleID}");
            Console.WriteLine($"Vehicle Name: {VehicleName}");
            Console.WriteLine($"Vehicle Fuel Level: {VehicleFuelLevel}");
            Console.WriteLine($"Vehicle Max Speed: {VehicleMaxSpeed}");
            Console.WriteLine($"Vehicle Fuel Capacity: {FuelCapacity}");
        }
    }
}
