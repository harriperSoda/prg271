using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Airport
{
    internal abstract class GroundVehicles
    {
        public int VehicleID { get; set; }
        public string VehicleName { get; set; }
        public int VehicleFuelLevel { get; set; }
        public int VehicleMaxSpeed { get; set; }

        public GroundVehicles(int vehicleID, string vehicleName, int vehicleFuelLevel, int vehicleMaxSpeed)
        
        {
            this.VehicleID = vehicleID;
            this.VehicleName = vehicleName;
            this.VehicleFuelLevel = vehicleFuelLevel;
            this.VehicleMaxSpeed = vehicleMaxSpeed;
        }

        public abstract void ShowVehicle();
        
    }
}
