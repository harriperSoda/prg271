using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<ArcadeMachine> aracadeMachines = new List<ArcadeMachine>();

            bool running = true;

            while (running)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add Arcade Machine");
                Console.WriteLine("2. Remove Arcade Machine");
                Console.WriteLine("3. Start Game");
                Console.WriteLine("4. Exit");

                if(int.TryParse(Console.ReadLine(), out int selection))
                {
                    MenuOptions choice = (MenuOptions)selection;

                    switch (choice)
                    {
                        case MenuOptions.AddMachine:
                            Pinnball pinmachine = new Pinnball(1, "Pinball");

                            break;

                        case MenuOptions.RemoveMachine:
                            break;


                    }
                        
                }
            }
        }
    }
}
