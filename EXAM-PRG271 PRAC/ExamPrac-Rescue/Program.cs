using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamPrac_Rescue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RescueUnit> allunits = new List<RescueUnit>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("SEARCH & RESCUE OPERATIONS");
                Console.WriteLine("==============================");

                Console.WriteLine("1. Add Rescue Unit");
                Console.WriteLine("2. Dispplay Rescue Units");
                Console.WriteLine("3. Start Emergency Operations");
                Console.WriteLine("4. Exit");
                 
                Console.WriteLine("Select Option: ");

                //Checking if option is int
                if (int.TryParse(Console.ReadLine(), out int menuChoice))
                {
                    Menu menu = (Menu)menuChoice; //cast the option into menu, an instanted variable from the Menu class

                    switch (menu)
                    {
                        case Menu.AddRescueUnit:
                            AddRescueUnit(allunits);
                            break;
                        case Menu.DisplayUnits:
                            ShowUnits(allunits);
                            break;
                        case Menu.StartOpps:
                            StartOp();
                            break;
                        case Menu.Exit:
                            running = false;
                            break;
                    }
                }
            }

        }
        public static void AddRescueUnit(List<RescueUnit> allUnits)
        {
            Console.WriteLine("1. Water Unit or Mountain Unit: ");
            if (int.TryParse(Console.ReadLine(), out int unitOpt))
            {
                switch (unitOpt)
                {
                    case 1:
                        Console.WriteLine("Enter Unit ID");
                        int rescueID = CheckID(allUnits);

                        Console.WriteLine("Enter Unit Name: ");
                        string rescueName = CheckName();

                        Console.WriteLine("Enter Crew Size: ");
                        int rescueCrewSize = CheckCrewSize();

                        Console.WriteLine("Enter readiness level: ");
                        int rescueReadyLevel = CheckLevel();

                        Console.WriteLine("Enter boat Capacity");
                        int boatCapacity = CheckCapacity();

                        WaterRescueUnit waterUnit = new WaterRescueUnit(
                            rescueID,
                            rescueName,
                            rescueCrewSize,
                            rescueReadyLevel,
                            boatCapacity);
                        allUnits.Add(waterUnit);
                        break;
                    case 2:
                        Console.WriteLine("Enter Unit ID");
                        int mountainRescueID = CheckID(allUnits);

                        Console.WriteLine("Enter Unit Name: ");
                        string MountainRescueName = CheckName();

                        Console.WriteLine("Enter Crew Size: ");
                        int mountainRescueCrewSize = CheckCrewSize();

                        Console.WriteLine("Enter readiness level: ");
                        int mountainRescueReadyLevel = CheckLevel();

                        Console.WriteLine("Enter climbing gear count: ");
                        int gearCount = CheckGear();

                        MountainRescueUnit mountainUnit = new MountainRescueUnit(mountainRescueID,
                            MountainRescueName,
                            mountainRescueCrewSize,
                            mountainRescueReadyLevel,
                            gearCount);
                        allUnits.Add(mountainUnit);
                        break;

                }
            }
        }
        public static int CheckID(List<RescueUnit> allUnits)
        {
            //check if its empty
            while (true)
            {
                string givenID = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(givenID))
                {
                    Console.WriteLine("You need to enter something");
                    continue;
                }
                if (!int.TryParse(givenID, out int ID))
                {
                    Console.WriteLine("Enter a number");
                    continue;
                }
                if (allUnits.Any(anID => anID.UnitID == ID))
                {
                    Console.WriteLine("You have entered a duplicate ID");
                    continue;
                }
                else
                {
                    return ID;
                }
            }
        }
        public static string CheckName()
        {
            while (true)
            {
                string giveName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(giveName))
                {
                    Console.WriteLine("Enter something");
                    continue;
                }
                return giveName;
            }
        }
        public static int CheckCrewSize()
        {
            while (true)
            {
                string givenSize = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(givenSize))
                {
                    Console.WriteLine("Enter something");
                    continue;
                }
                if (!int.TryParse(givenSize, out int crewSize))
                {
                    Console.WriteLine("Crew size must be a number");
                    continue;
                }
                if (crewSize < 0)
                {
                    Console.WriteLine("Crew size cant be negative");
                    continue;
                }
                return crewSize;
            }
        }
        public static int CheckLevel()
        {
            while (true)
            {
                string givenLevel = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(givenLevel))
                {
                    Console.WriteLine("Enter some text");
                    continue;
                }
                if (!int.TryParse(givenLevel, out int readyLevel))
                {
                    Console.WriteLine("Enter a number between 1 and 5");
                    continue;
                }
                if (readyLevel < 1 || readyLevel > 5)
                {
                    Console.WriteLine("Enter a number between 1 and 5");
                    continue;
                }
                return readyLevel;
            }
        }
        public static int CheckCapacity()
        {
            while (true)
            {
                string givenCapacity = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(givenCapacity))
                {
                    Console.WriteLine("Enter something");
                    continue;
                }
                if (!int.TryParse(givenCapacity, out int capacity))
                {
                    Console.WriteLine("Enter a number");
                    continue;
                }
                if (capacity < 0)
                {
                    Console.WriteLine("Capacity cant be negative");
                    continue;
                }
                return capacity;
            }
        }
        public static int CheckGear()
        {
            while (true)
            {
                string givenCount = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(givenCount))
                {
                    Console.WriteLine("Enter something");
                    continue;
                }
                if (!int.TryParse(givenCount, out int count))
                {
                    Console.WriteLine("Enter a number");
                    continue;
                }
                if (count < 0)
                {
                    Console.WriteLine("cOUNT cant be negative");
                    continue;
                }
                return count;

            }
        }

        public static void ShowUnits(List<RescueUnit> allUnits)
        {
            foreach (RescueUnit unit in allUnits)
            {
                unit.DisplayUnits();
            }
        }
        public static void StartOp()
        {
            


            Thread mountainRes = new Thread(MountainR.PerformRescue);
            Thread waterRes = new Thread(WaterR.PerformRescue);

            mountainRes.Start();
            waterRes.Start();

            mountainRes.Join();
            waterRes.Join();
        }
    }
}
