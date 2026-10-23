using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymExamPrac
{
    internal class GymEquipment
    {
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public int maxWeightCapacityKg { get; set; }
        public string AvailabilityStatus { get; set; }

        public GymEquipment(int equipmentID, string equipmentName, int maxWeightCapacityKg, string availabilityStatus)
        {
            this.EquipmentID = equipmentID;
            this.EquipmentName = equipmentName;
            this.maxWeightCapacityKg = maxWeightCapacityKg;
            this.AvailabilityStatus = availabilityStatus;
        }

        public void DisplayEquipmentInfo()
        {
            Console.WriteLine($"Equipment ID: {EquipmentID}");
            Console.WriteLine($"Equipment Name: {EquipmentName}");
            Console.WriteLine($"Max Weight Capacity (Kg): {maxWeightCapacityKg}");
            Console.WriteLine($"Availability Status: {AvailabilityStatus}");
        }
    }
}
