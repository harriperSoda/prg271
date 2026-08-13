using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace PracRecap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>();

            bool running = true;

            while (running)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Add Dog");
                Console.WriteLine("2. Add Cat");
                Console.WriteLine("2. View All Pets");
                Console.WriteLine("4. Exit");


                if (int.TryParse(Console.ReadLine(), out int MenuOption))
                {
                    MenuOptions choice = (MenuOptions)MenuOption;


                    switch (choice)
                    {
                        case MenuOptions.AddDog:
                            Dog newDog = new Dog(1, "Jonno", 12);
                            pets.Add(newDog);
                            break;

                        case MenuOptions.AddCat:
                            Cat newCat = new Cat(2, "Jenkins", 5);
                            pets.Add(newCat);
                            break;
                        case MenuOptions.DisplayAllPets:
                            if (pets.Count == 0)
                            {
                                Console.WriteLine("No pets available.");
                            }
                            else
                            {
                                foreach (Pet animal in pets)
                                {
                                    animal.PetInfo();
                                }
                            }
                            break;
                        case MenuOptions.Exit:
                            running = false;
                            break;
                    }
                }
            }

        }
    }
}
