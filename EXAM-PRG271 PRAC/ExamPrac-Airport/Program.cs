using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrac_Airport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GroundVehicles> allGroundVehicles = new List<GroundVehicles>();


            bool running = true;
            while (running)
            {
                Console.WriteLine("================================");
                Console.WriteLine("AIRPORT GROUND OPERATIONS");
                Console.WriteLine("================================");

                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. Display Vehicles");
                Console.WriteLine("3. Start Ground Operations");
                Console.WriteLine("4. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    Menu menuOpts = (Menu)choice;

                    switch (menuOpts)
                    {
                        case Menu.AddVehicle:
                            Console.WriteLine("1. Baggage Truck 2. Fuel Truck");
                            {
                                try
                                {
                                    if (int.TryParse(Console.ReadLine(), out int truckType))
                                    {
                                        switch (truckType)
                                        {
                                            case 1:
                                                Console.WriteLine("Enter Vehicle ID: ");
                                                int truckID = CheckID(allGroundVehicles);
                                                Console.WriteLine("Enter Vehicle Name: ");
                                                string truckName = CheckName();
                                                Console.WriteLine("Enter Vehicle Fuel Level: ");
                                                int truckFuel = CheckFuel();
                                                Console.WriteLine("Enter Max Speed: ");
                                                int truckSpeed = MaxSpeed();
                                                Console.WriteLine("Enter load capacity: ");
                                                int truckCapacity = CheckCapacity();

                                                FuelTruckVehicle fuelTruck = new FuelTruckVehicle(truckID, truckName, truckFuel, truckSpeed, truckCapacity);
                                                allGroundVehicles.Add(fuelTruck);
                                                break;

                                            case 2:
                                                Console.WriteLine("Enter Vehicle ID: ");
                                                int fuelTruckID = CheckID(allGroundVehicles);
                                                Console.WriteLine("Enter Vehicle Name: ");
                                                string fuelTruckName = CheckName();
                                                Console.WriteLine("Enter Vehicle Fuel Level: ");
                                                int fuelTruckFuel = CheckFuel();
                                                Console.WriteLine("Enter Max Speed: ");
                                                int fuelTruckSpeed = MaxSpeed();
                                                Console.WriteLine("Enter fuel trucsk fuel capacity: ");
                                                int fuelTank = CheckFuel();

                                                FuelTruckVehicle fTruck = new FuelTruckVehicle(fuelTruckID, fuelTruckName, fuelTruckFuel, fuelTruckSpeed, fuelTank);
                                                allGroundVehicles.Add(fTruck);
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        throw new InvalidSelectionCustomException("Make a valid selection between 1 and 2");
                                    }
                                }
                                catch (InvalidSelectionCustomException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }

                            break;

                        case Menu.DisplayVehicles:
                            ShowVehicles(allGroundVehicles);
                            break;
                        case Menu.StartGroundOperations:
                            StartGrndOpps();
                            break;
                        case Menu.Exit:
                            running = false;
                            break;
                    }
                }
            }

        }

        public static int CheckID(List<GroundVehicles> allGroundVehicles)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int givenID))
                {
                    Console.WriteLine("Enter a numeric character");
                    continue;
                }
                if (allGroundVehicles.Any(vehicle => vehicle.VehicleID == givenID))
                {
                    Console.WriteLine("ID already exists");
                    continue;
                }
                return givenID;

            }
        }
        public static string CheckName()
        {
            string name = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Enter alphabetic characters");
                    continue;
                }
                return name;
            }
        }
        public static int CheckFuel()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int givenFuel))
                {
                    Console.WriteLine("Enter numeric value");
                    continue;
                }
                if (givenFuel < 100 || givenFuel > 1000)
                {
                    Console.WriteLine("Fuel limits abnormal. Greater than 100 and less than 1000");
                    continue;
                }
                return givenFuel;
            }
        }
        public static int MaxSpeed()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int givenSpeed))
                {
                    Console.WriteLine("Enter numeric value");
                    continue;
                }
                if (givenSpeed < 5 || givenSpeed > 120)
                {
                    Console.WriteLine("Speed limits abnormal. Greater than 5 and less than 120");
                    continue;
                }
                return givenSpeed;
            }

        }
        public static int CheckCapacity()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int givenCapacity))
                {
                    Console.WriteLine("Enter numeric value");
                    continue;
                }
                if (givenCapacity < 5 || givenCapacity > 120)
                {
                    Console.WriteLine("capacity limits abnormal. Greater than 5 and less than 120");
                    continue;
                }
                return givenCapacity;
            }
        }
        public static void ShowVehicles(List<GroundVehicles> allGroundVehicles)
        {
            foreach(GroundVehicles groundVehicle  in allGroundVehicles)
            {
                groundVehicle.ShowVehicle();
            }
        }
        public static void StartGrndOpps()
        {
            Thread groundBaggage = new Thread(GroundOppBaggageTruck.BaggageTruckStart);
            Thread fuelTruck = new Thread(GroundOppFuelTruck.FuelTruckStart);

            groundBaggage.Start();
            fuelTruck.Start();

            groundBaggage.Join();
            fuelTruck.Join();
        }
    }
}
