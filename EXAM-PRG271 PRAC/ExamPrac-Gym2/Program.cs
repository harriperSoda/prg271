using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Members> allMembers = new List<Members>();
            List<Bookings> allBookings = new List<Bookings>();
            List<int> passID = new List<int>();


            bool running = true;

            while (running)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("GYM ACCESS & COACHING SYSTEM");
                Console.WriteLine("====================================");

                Console.WriteLine("1. Add Member");
                Console.WriteLine("2. Display All Members");

                Console.WriteLine("3. Add Coaching Booking");
                Console.WriteLine("4. Display All Bookings");

                Console.WriteLine("5. Add Access Pass");
                Console.WriteLine("6. Display All Access Passes");

                Console.WriteLine("7. Start Floor Acivities");
                Console.WriteLine("8. Exit");

                if(int.TryParse(Console.ReadLine(), out int menuChoice))
                {
                    MenuOpts menuOption = (MenuOpts)menuChoice;

                    switch (menuOption)
                    {
                        case MenuOpts.AddMember:
                            AddMember(allMembers);
                            break;

                        case MenuOpts.DisplayMemebrs:
                            break;
                        case MenuOpts.AddCoachingBooking:
                            break;

                        case MenuOpts.DisplayCoachingBookings:
                            break;

                        case MenuOpts.AddAccessPass:
                            break;

                        case MenuOpts.DisplayAccessPasses:
                            break;

                        case MenuOpts.StartGymFloorActivities:
                            break;

                        case MenuOpts.Exit:
                            running = false;
                            break;
                    }
                }
            }
        }

        static void AddMember(List<Members> allMembers)
        {
            Console.WriteLine("Enter Member Type: 1. Standard 2. Athlete 3. Student");

            if (int.TryParse(Console.ReadLine(), out int memberType))
            {
                switch (memberType)
                {
                    case 1:
                        Console.WriteLine("Enter Member ID: ");
                        int memberID = CheckIDNumber(allMembers);

                        Console.WriteLine("Enter Member Name: ");
                        string memberName = Console.ReadLine();

                        Console.WriteLine("Enter Member Age: ");
                        int memberAge = CheckAge(allMembers);

                        Console.WriteLine("Enter Membership Months: ");
                        int membershipMonths = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Current Status: ");
                        string currentStatus = Console.ReadLine();

                        Console.WriteLine("Enter their monthly fee: ");
                        int monthlyFee = int.Parse(Console.ReadLine());

                        StandardMember newMember = new StandardMember(
                            memberID,
                            memberName,
                            memberAge,
                            membershipMonths,
                            currentStatus,
                            monthlyFee);

                        allMembers.Add(newMember);
                        break;

                    case 2:
                        Console.WriteLine("Enter Member ID: ");
                        int athleteMemberID = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Member Name: ");
                        string athleteMemberName = Console.ReadLine();

                        Console.WriteLine("Enter Member Age: ");
                        int athleteMemberAge = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Membership Months: ");
                        int athleteMembershipMonths = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Current Status: ");
                        string athleteCurrentStatus = Console.ReadLine();

                        Console.WriteLine("Enter your sport type: ");
                        string sportType = Console.ReadLine();

                        AthleteMember newAthleteMember = new AthleteMember(
                            athleteMemberID,
                            athleteMemberName,
                            athleteMemberAge,
                            athleteMembershipMonths,
                            athleteCurrentStatus,
                            sportType);

                        allMembers.Add(newAthleteMember);
                        break;

                    case 3:
                        Console.WriteLine("Enter Member ID: ");
                        int studentMemberID = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Member Name: ");
                        string studentMemberName = Console.ReadLine();

                        Console.WriteLine("Enter Member Age: ");
                        int studentMemberAge = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Membership Months: "); 
                        int studentMembershipMonths = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Current Status: ");
                        string studentCurrentStatus = Console.ReadLine();

                        Console.WriteLine("Enter your academic institution: ");  
                        string academicInstitution = Console.ReadLine();

                        StudentMember newStudent = new StudentMember(
                            studentMemberID,
                            studentMemberName,
                            studentMemberAge,
                            studentMembershipMonths,
                            studentCurrentStatus,
                            academicInstitution);
                        allMembers.Add(newStudent);
                        break;

                }
            }
            
        }

        static int CheckIDNumber(List<Members> allMembers)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int givenID))
                {
                    Console.WriteLine("Enter a number only.");
                    continue;
                }
                if(allMembers.Any(member => member.MemberID == givenID)) //For each member in the list, check if each members member id...
                {
                    Console.WriteLine("ID already exists. Please enter a unique ID.");
                    continue;
                }
                return givenID;

            }
            
        }
        static string CheckNames(List<Members> allMembers)
        {
            return "";
        }
        static int CheckAge(List<Members> allMembers)
        {
            while (true)
            {

                if (!int.TryParse(Console.ReadLine(), out int givenAge))
                {
                    Console.WriteLine("Enter a number only.");
                    continue;
                }
                if (givenAge < 0 || givenAge > 120)
                {
                    Console.WriteLine("Enter a valid age between 0 and 120.");
                    continue;
                }
                if (givenAge < 18)
                {
                    Console.WriteLine("You must be at least 18 years old to join the gym.");
                    continue;
                }

                return givenAge;


            }
        }


    }
}
