using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> allCharacters = new List<Character>();
            List<Mission> allMissions = new List<Mission>();
            List<Threat> allThreats = new List<Threat>();


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
                Console.WriteLine("5. Add Threat");
                Console.WriteLine("6. Start Opperations");
                Console.WriteLine("7. Exit");

                if (int.TryParse(Console.ReadLine(), out int selectedOption))
                {
                    MenuOptions option = (MenuOptions)selectedOption;
                    
                    switch(option)
                    {
                        case MenuOptions.AddCharacter:
                            AddCharacter(allCharacters); //Go to AddCharacter method. Run the AddCharacter method, and give that method access to the existing characters list. We are invoking here and giving it the value. Similar to ShowAge(20)
                            //
                            break;

                        case MenuOptions.DisplayCharacters:
                            ShowCharacters(allCharacters);
                            break;

                        case MenuOptions.AddMission:
                            AddMission(allMissions);
                            break;
                        case MenuOptions.DisplayMissions:
                            ShowMissions(allMissions);
                            break;
                        case MenuOptions.AddThreat:
                            AddThreat(allThreats);
                            break;
                        case MenuOptions.StartOperations:
                            break;
                        case MenuOptions.Exit:
                            running = false;
                            break;
                    }
                }
            }
        }

        static void AddCharacter(List<Character> characters) //Define the method and pass the parametre, NOT value
        {
            Console.WriteLine("Choose character type:");
            Console.WriteLine("1. Aragorn");
            Console.WriteLine("2. Gandalf");
            Console.WriteLine("3. Legolas");
            Console.WriteLine("4. Gollum");

            int characterType = int.Parse(Console.ReadLine()); //Come hack to using .TryParse

            Console.Write("Enter character ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter character name: ");
            string name = Console.ReadLine();

            Console.Write("Enter character age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter character strength level: ");
            int strengthLevel = int.Parse(Console.ReadLine());

            switch (characterType)
            {
                case 1:
                  
                    string weapon = "Weapon Type";

                    Aragorn aragorn = new Aragorn
                        (
                            id,
                            name,
                            age,
                            strengthLevel,
                            weapon
                        );
                    characters.Add(aragorn);
                    break;

                case 2:
                    string staffType = "Staff type";
                    Gandalf gandalf = new Gandalf
                        (
                        id,
                        name,
                        age,
                        strengthLevel,
                        staffType
                        );
                    characters.Add(gandalf);
                    break;

                case 3:
                    string bowType = "Bow Type";
                    Legolas legolas = new Legolas
                        (
                        id, name, age, strengthLevel, bowType
                        );
                    characters.Add(legolas);
                    break;

                case 4:
                    string caveLocation = "Cave Location";
                    Gollum gollum = new Gollum
                        (id, name, age, strengthLevel, caveLocation);
                    characters.Add(gollum);
                    break;

            }
                       
        }
        static void ShowCharacters(List<Character> characters)
        {
            foreach(Character character in characters) //foreach (Type item in collection)
            {
                //Console.WriteLine($"ID: {character.id}, Name: {character.name}, Age: {character.age}, Strength Level: {character.strengthLevel}");
                character.callCharacter();
            }
        }
        static void AddMission(List<Mission> missions)
        {
            Console.WriteLine("Enter mission type");
            Console.WriteLine("1. Search Mission");
            Console.WriteLine("2. Rescue Mission"); 
            Console.WriteLine("3. Combat Mission");

            int missionType = int.Parse(Console.ReadLine());

            Console.Write("Enter mission ID: ");
            int missionId = int.Parse(Console.ReadLine());

            Console.Write("Enter mission name: ");
            string name = Console.ReadLine();

            Console.Write("Enter mission location: ");
            string location = Console.ReadLine();

            Console.Write("Enter mission danger level: ");
            int dangerLevel = int.Parse(Console.ReadLine());

            Console.Write("Enter mission completion status: ");
            string completionStatus = Console.ReadLine();

            try
            {

                switch (missionType)
                {
                    case 1:
                        //create SearchMission object
                        SearchMission searchMission = new SearchMission(
                            missionId,
                            name,
                            location,
                            dangerLevel,
                            completionStatus);
                        missions.Add(searchMission);
                        break;

                    case 2:
                        RescueMission rescueMission = new RescueMission(
                            missionId,
                            name,
                            location,
                            dangerLevel,
                            completionStatus);
                        //add to missions list
                        missions.Add(rescueMission);
                        break;

                    case 3:
                        CombatMission combatMission = new CombatMission(
                            missionId,
                            name,
                            location,
                            dangerLevel,
                            completionStatus);
                        //add to missions list
                        missions.Add(combatMission);
                        break;
                }
            }
            catch(InvalidDangerLevelException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ShowMissions(List<Mission> missions)
        {
            foreach(Mission mission in missions)
            {
                mission.showMission();
            }
        }
        static void AddThreat(List<Threat> threats)
        {
            Console.WriteLine("Enter Thread ID: ");
            int threatID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter threat name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter threat Location: ");
            string location = Console.ReadLine();
            Console.WriteLine("Enter threat danger level: ");
            int dangerLevel = int.Parse(Console.ReadLine());

            try
            {
                Threat threat = new Threat(
                threatID,
                name,
                location,
                dangerLevel);
                threats.Add(threat);
            }
            catch(InvalidDangerLevelException ex) //Invalid... is the type of expcetion the catch is looking for. ex is the variable name of the exception object. You can call it whatever you want, but ex is common.
            {
                Console.WriteLine(ex.Message); //ex.Message is a property of the exception object that contains the error message associated with the exception.
            }


            
        }
    }


}
