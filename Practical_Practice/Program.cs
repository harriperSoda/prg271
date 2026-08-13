using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Opening Hell's Kitchen...");

            // 2. CREATE YOUR LISTS HERE (Before the loop!)
            List<Contestant> contestantList = new List<Contestant>();
            List<RestaurantServices> serviceList = new List<RestaurantServices>();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Register Pastry Chef");
                Console.WriteLine("2. Register Grill Chef");
                Console.WriteLine("3. View All Contestants");
                Console.WriteLine("4. Start Standard Service");
                Console.WriteLine("5. Start VIP Service");
                Console.WriteLine("6. Record Incident");
                Console.WriteLine("7. Exit");

                //read inputs 
                if (int.TryParse(Console.ReadLine(), out int inputtedOption))
                {
                       //Cast integer to the enum
                    MenuOptions choice = (MenuOptions)inputtedOption;

                    //Switch on enum
                    switch (choice)
                    {
                        case MenuOptions.RegisterPastryChef:
                            PastryChef pChef = new PastryChef(1, "Chef Madhir", 22, 3, "blue");
                            contestantList.Add(pChef);
                            Console.WriteLine("SUCCESS: Pastry Chef added!");
                            break;

                        case MenuOptions.RegisterGrillChef:
                            GrillChef gChef = new GrillChef(2, "Chef Ramesh", 24, 3, "Blue");
                            contestantList.Add(gChef);
                            Console.WriteLine("SUCCESS: Grill Chef added!");
                            break;

                        case MenuOptions.ViewAllContestants:
                            Console.WriteLine("\nAll Registed Contestant");
                                if (contestantList.Count == 0)
                            {
                                Console.WriteLine("No contestants");
                            }
                            else
                            {
                                foreach (Contestant chef in contestantList)
                                {
                                    chef.prepareDish();
                                }
                                
                            }
                            break;
                            



                    }

                }
                

            }
        }
    }
}
