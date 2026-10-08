using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymExamPrac
{
    internal class Program
    {
        static void Main(string[] args)

        //creation of lists to hold members, training sessions and equipment
        {
            List<GymMembers> allMembers = new List<GymMembers>();
            List<Sessions> trainingSessions = new List<Sessions>();
            List<GymEquipment> equipment = new List<GymEquipment>();

            //Display the menu options and use a loop to allow interaction till exit
            bool running = true;
            while (running) 
            {
                Console.WriteLine("=========Welcome to the Gym Management System=========");
                Console.WriteLine("=======================================================");

                Console.WriteLine("1. Add Member");
                Console.WriteLine("2. Display Members");
                Console.WriteLine("3. Add Training Session");
                Console.WriteLine("4. Display Training Sessions");
                Console.WriteLine("5. Add Equipment");
                Console.WriteLine("6. Display Equipment");
                Console.WriteLine("7. Start Gym Operations");
                Console.WriteLine("8. Exit");

                //get user input
                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    //begin switch but first need to create instance of enum
                    MenuEnum menuEnum = (MenuEnum)choice; //cast the choice into the MenuEnum type

                    switch (menuEnum)
                    {
                        case MenuEnum.AddMember:
                            AddMember(allMembers);
                            break;

                        case MenuEnum.DisplayMembers:
                            DisplayMembers(allMembers);
                            break;

                        case MenuEnum.AddTrainingSession:
                            AddTrainingSession(trainingSessions);
                            break;

                        case MenuEnum.DisplayTrainingSessions:
                            break;

                        case MenuEnum.AddEquipment:
                            break;

                        case MenuEnum.DisplayEquipment:
                            break;

                        case MenuEnum.StartGymOpeations:
                            break;

                        case MenuEnum.Exit:
                            running = false;
                            break;
                    }
                }

            }         
        }

        static void AddMember(List<GymMembers> members)
        {
            Console.WriteLine("Enter member type");
            Console.WriteLine("1. Bodybuilder");
            Console.WriteLine("2. Powerlifter");
            Console.WriteLine("3. Runner");

            int membeerTypeChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter member ID");
            int memberID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter member name");
            string memberName = Console.ReadLine();
            Console.WriteLine("Enter member age");
            int memberAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter membership type");
            string membershipType = Console.ReadLine();

            //Thinking i need to declare the specific member type variables here to be used in the switch statement below
         

            switch (membeerTypeChoice)
            {
                case 1:
                    Console.WriteLine("Enter your weight");
                    double bodybuilderWeight = double.Parse(Console.ReadLine());
                    //instance of Bodybuilder
                    Bodybuilder bodybuilder = new Bodybuilder(memberID, memberName, memberAge, membershipType, bodybuilderWeight);
                    members.Add(bodybuilder);
                    break;
                case 2:
                    Console.WriteLine("Enter your best squat in KG: ");
                    double bestSquat = double.Parse(Console.ReadLine());
                    //instance of Powerlifter
                    Powerlifter powerlifter = new Powerlifter(memberID, memberName, memberAge, membershipType, bestSquat);
                    members.Add(powerlifter);
                    break;
                case 3:
                    Console.WriteLine("Enter your best 5k time in minutes: ");
                    double best5kTime = double.Parse(Console.ReadLine());
                    //instance of Runner
                    Runner runner = new Runner(memberID, memberName, memberAge, membershipType, best5kTime);
                    members.Add(runner);
                    break;
            }
        }
        static void DisplayMembers(List<GymMembers> members)
        {
            foreach(GymMembers member in members)
            {
                member.DisplayMemberDetails();
            }
        }
        static void AddTraingSession(List<Sessions> trainingSessions)
        {
            Console.WriteLine("What training session would you like to add?");
            Console.WriteLine("1. Strength Session");
            Console.WriteLine("2. Cardio Session");
            Console.WriteLine("3. Mobility Session");

            int sessionChoice = int.Parse(Console.ReadLine());

            switch (sessionChoice)
            {
                case 1:
                    Console.WriteLine("Enter session ID"); //wanna change this to eventualy just increment the session ID automatically
                    int sessionID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter session name");
                    string sessionName = Console.ReadLine();
                    Console.WriteLine("Enter session duration in minutes");
                    int sessionDurationMin = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter session difficulty");
                    string sessionDifficulty = Console.ReadLine();
                    Console.WriteLine("Enter session completion status");
                    string sessionCompletionStatus = Console.ReadLine();

                    Console.WriteLine("Enter the sessions objective");
                    string sessionObjective = Console.ReadLine();

                    StrengthSession strengthSession = new StrengthSession(sessionID, sessionName, sessionDurationMin, sessionDifficulty, sessionCompletionStatus, sessionObjective);
                    trainingSessions.Add(strengthSession);
                    break;
            }
        }
    }
   
}
