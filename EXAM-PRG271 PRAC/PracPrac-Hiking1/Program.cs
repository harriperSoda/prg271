using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PracPrac_Hiking1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<HikingTrail> hikingTrails = new List<HikingTrail>();


            while (true)
            {

                Console.WriteLine("=============================");
                Console.WriteLine("HIKING TRAIL SYSTEM");
                Console.WriteLine("=============================");

                Console.WriteLine("1. Add Trail");
                Console.WriteLine("2. Display Trails");
              
                Console.WriteLine("4. Start Hiking Day");
                Console.WriteLine("5. Exit");

                //Get user input, try parse and begin case statement

                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    Menu menuChoice = (Menu)choice;

                    switch (menuChoice)
                    {
                        case Menu.AddTrail:
                            Console.WriteLine("Select Trail Type: 1. Mountain Trail, 2. Forest Trail");

                            if(int.TryParse(Console.ReadLine(), out int trailChoice))
                            {
                                switch (trailChoice)
                                {
                                    case 1: //Mountain Trail
                                        Console.WriteLine("Enter Trail ID: ");
                                        int trailID = CheckID(hikingTrails); 

                                        Console.WriteLine("Enter Trail Name: ");
                                        string trailName = CheckTrailName(hikingTrails);

                                        Console.WriteLine("Enter trail distance: ");
                                        double trailDistance = CheckDistance();

                                        Console.WriteLine("Enter Difficulty: ");
                                        string trailDifficulty = CheckDifficulty();

                                        Console.WriteLine("Enter trail duration: ");
                                        int trailDuration = CheckDuration();

                                        Console.WriteLine("Enter elevation gain");
                                        double trailElevation = CheckElevation();

                                        MountainTrail mTrail = new MountainTrail(
                                            trailID, trailName, trailDistance, trailDifficulty, trailDuration, trailElevation);
                                        hikingTrails.Add(mTrail);
                                        break;

                                    case 2: //Forest trail
                                        Console.WriteLine("Enter Trail ID: ");
                                        int FtrailID = CheckID(hikingTrails);

                                        Console.WriteLine("Enter Trail Name: ");
                                        string FtrailName = CheckTrailName(hikingTrails);

                                        Console.WriteLine("Enter trail distance: ");
                                        double FtrailDistance = CheckDistance();

                                        Console.WriteLine("Enter Difficulty: ");
                                        string FtrailDifficulty = CheckDifficulty();

                                        Console.WriteLine("Enter trail duration: ");
                                        int FtrailDuration = CheckDuration();

                                        Console.WriteLine("Enter wildlife risk: ");
                                        string FwildLifeRisk = CheckWildRisk();

                                        ForestTrail fTrail = new ForestTrail(
                                            FtrailID, FtrailName, FtrailDistance, FtrailDifficulty, FtrailDuration, FwildLifeRisk);
                                        hikingTrails.Add(fTrail);
                                        break;

                                }
                            }

                            break;
                        case Menu.DisplayTrails:

                            ShowTrails(hikingTrails);
                            break;
                        //
                        case Menu.StartHikingDay:
                            StartActivities();
                            break;
                    }
                }
            }
        }

        public static int CheckID(List<HikingTrail> hikingTrails)
        {
            //check that its a valid int

            while (true)
            {
                try
                {
                    if(!int.TryParse(Console.ReadLine(), out int givenID))
                    {
                        Console.WriteLine("Only enter a numeric value for the ID");
                        continue;
                    }
                    if(hikingTrails.Any(trail => trail.TrailID == givenID))
                    {
                        throw new DuplicateIDException("This ID already exists. Please enter a unique ID.");
                    }
                    return givenID;
                }
                catch(DuplicateIDException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

           

        }
        public static string CheckTrailName(List<HikingTrail> hikingTrails)
        {
            while (true)
            {
                string givenTrailName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(givenTrailName))
                {
                    Console.WriteLine("Please input something");
                    continue;
                }
                //if(hikingTrails.Any(trail => trail.TrailName = givenTrailName))
                //{

                //}
                return givenTrailName;
            }
        }
        public static double CheckDistance()
        {
            while (true)
            {
                try
                {
                    if (!int.TryParse(Console.ReadLine(), out int givenDistance))
                    {
                        throw new InvalidDistanceCustomException("Enter an integer for distance");
                    }
                    if(givenDistance < 1 || givenDistance > 300)
                    {
                        Console.WriteLine("Enter a distance between 1 and 299");
                    }
                    return givenDistance;
                }
                catch(InvalidDistanceCustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static string CheckDifficulty()
        {
            while (true)
            {
                string givenDifficulty = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(givenDifficulty))
                {
                    Console.WriteLine("Enter something chracters");
                    continue;
                }
                if (givenDifficulty == "Easy" || givenDifficulty == "Medium" || givenDifficulty == "Hard")
                {
                    return givenDifficulty;
                }
                else
                {
                    Console.WriteLine("Enter a valid difficulty: Easy, Medium Hard");
                    continue;
                }
            }
        }
        public static int CheckDuration()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int givenDuration))
                {
                    Console.WriteLine("Invalid entry");
                    continue;
                }
                if(givenDuration < 1 || givenDuration > 1000)
                {
                    Console.WriteLine("Enter sensible duration time");
                    continue;
                }
                return givenDuration;
            }
        }
        public static double CheckElevation()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int givenElevation))
                {
                    Console.WriteLine("Enter a number");
                    continue;
                }
                if(givenElevation < 1 || givenElevation > 8000)
                {
                    Console.WriteLine("Enter a sensible elevation gain");
                    continue;
                }
                return givenElevation;
            }
        }
        public static string CheckWildRisk()
        {
            string givenWildLife = Console.ReadLine();

            while (true)
            {

                if (string.IsNullOrWhiteSpace(givenWildLife))
                {
                    Console.WriteLine("Please enter something");
                    continue;

                }
                if (givenWildLife == "Low" || givenWildLife == "High")
                {
                    return givenWildLife;
                }
                else
                {
                    Console.WriteLine("Enter low or high");
                    continue;
                }

            }
        }
        public static void ShowTrails(List<HikingTrail> trails)
        {
            foreach(HikingTrail aTrail in trails)
            {
                aTrail.DisplayTrail();
            }

        }
        public static void StartActivities()
        {
            Thread mountainThread = new Thread(MountainHikingActivities.mountainHiking);
            Thread forestThread = new Thread(ForestHikingActivities.ForestHike);

            mountainThread.Start();
            forestThread.Start();

            mountainThread.Join();
            forestThread.Join();
        }
    }
}
