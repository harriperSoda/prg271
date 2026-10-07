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
            List<GymMembers> members = new List<GymMembers>();
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
                            //AddMember(members);
                            break;

                        case MenuEnum.DisplayMembers:
                            break;

                        case MenuEnum.AddTrainingSession:
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

        }
    }

   
}
