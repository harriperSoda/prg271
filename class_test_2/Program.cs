using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //create list for characters
            List<Character> characters = new List<Character>();
            List< MIssion> missions = new List<MIssion>();

            bool running = true;

            while (running)
            {
                Console.WriteLine("================================");
                Console.WriteLine("MIDDLE-EARTH OPERATIONS");
                Console.WriteLine("================================");

                Console.WriteLine("1. Add Character");
                Console.WriteLine("2. Display Characters");
                Console.WriteLine("3. Add MIssion");
                Console.WriteLine("4. Display Missions");
                Console.WriteLine("Add Threat");
                Console.WriteLine("Start Opperations");
                Console.WriteLine("Exit");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    MenuOptions choice = (MenuOptions)option;

                    switch (choice)
                    {
                        case MenuOptions.AddCharacter:
                            Console.WriteLine("Enter Character ID: ");
                            int characterID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Character Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Character Age: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Character Strength Level: ");
                            int strengthLevel = int.Parse(Console.ReadLine());
                            Console.WriteLine("Select Character Type (1. Gandalf, 2. Legolas, 3. Gollum): ");
                            int characterType = int.Parse(Console.ReadLine());
                            Character newCharacter;
                            switch (characterType)
                            {
                                case 1:
                                    newCharacter = new Gandalf(characterID, name, age, strengthLevel);
                                    break;
                                case 2:
                                    newCharacter = new Legolas(characterID, name, age, strengthLevel);
                                    break;
                                case 3:
                                    newCharacter = new Gollum(characterID, name, age, strengthLevel);
                                    break;
                                default:
                                    Console.WriteLine("Invalid character type selected.");
                                    continue;
                            }
                            characters.Add(newCharacter);
                            Console.WriteLine($"Character {name} added successfully!");
                            break;
                        case MenuOptions.DisplayCharacters:
                            if(characters.Count == 0)
                            {
                                Console.WriteLine("NO characters to display");
                            }
                            else
                            {
                                foreach(Character character in characters)
                                {
                                    character.SummonCharacter();
                                }
                            }
                            break;

                        case MenuOptions.AddMission:
                            //get details and add to list
                            Console.WriteLine("Enter Mission ID: ");
                            int missionID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Mission Name: ");
                            string missionName = Console.ReadLine();
                            Console.WriteLine("Enter location");
                            string location = Console.ReadLine();
                            Console.WriteLine("Enter danger level");
                            int dangerLevel = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter completion level");
                            int completionLevel = int.Parse(Console.ReadLine());
                            missions.Add(new MIssion(missionID, missionName, location, dangerLevel, completionLevel));
                            Console.WriteLine("Mission added successfully!");
                            break;
                        case MenuOptions.DisplayMIssions:
                            if(missions.Count == 0)
                            {
                                Console.WriteLine("NO missions to show bro");
                            }
                            else
                            {
                                foreach(MIssion mission in missions)
                                {
                                    mission.DisplayMission();
                                }   
                            }
                            break;









                    }

                }
            }
        }
    }
}
