using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExamPrac_Gym2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Members> allMembers = new List<Members>();
            List<Bookings> allBookings = new List<Bookings>();
            List<Passes> passID = new List<Passes>();


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
                            ShowMembers(allMembers);
                            break;
                        case MenuOpts.AddCoachingBooking:
                            AddCoachBooking(allBookings);
                            break;

                        case MenuOpts.DisplayCoachingBookings:
                            ShowBookings(allBookings);
                            break;

                        case MenuOpts.AddAccessPass:
                            AddAccessPass(passID);
                            break;

                        case MenuOpts.DisplayAccessPasses:
                            ShowAccessPasses(passID);
                            break;

                        case MenuOpts.StartGymFloorActivities:
                            StartGymFloorActivities();
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
                        string memberName = CheckNames();

                        Console.WriteLine("Enter Member Age: ");
                        int memberAge = CheckAge();

                        Console.WriteLine("Enter Membership Months: ");
                        int membershipMonths = CheckMonths();

                        Console.WriteLine("Enter Current Status: ");
                        string currentStatus = CheckStatus();

                        Console.WriteLine("Enter their monthly fee: ");
                        int monthlyFee = CheckFee(allMembers);

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
                        int athleteMemberID = CheckIDNumber(allMembers);

                        Console.WriteLine("Enter Member Name: ");
                        string athleteMemberName = CheckNames();

                        Console.WriteLine("Enter Member Age: ");
                        int athleteMemberAge = CheckAge();

                        Console.WriteLine("Enter Membership Months: ");
                        int athleteMembershipMonths = CheckMonths();

                        Console.WriteLine("Enter Current Status: ");
                        string athleteCurrentStatus = CheckStatus();

                        Console.WriteLine("Enter your sport type: ");
                        string sportType = CheckSport();

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
                        int studentMemberID = CheckIDNumber(allMembers);

                        Console.WriteLine("Enter Member Name: ");
                        string studentMemberName = CheckNames();

                        Console.WriteLine("Enter Member Age: ");
                        int studentMemberAge = CheckAge();

                        Console.WriteLine("Enter Membership Months: "); 
                        int studentMembershipMonths = CheckMonths();

                        Console.WriteLine("Enter Current Status: ");
                        string studentCurrentStatus = CheckStatus();

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
        static void ShowMembers(List<Members> allMembers)
        {
            foreach(Members member in allMembers)
            {
                member.DisplayMemberInfo();
            }
        }
        static void AddCoachBooking(List<Bookings> allBookings)
        {
            Console.WriteLine("Enter Booking ID: ");
            int bookingID = CheckBookingID(allBookings);

            Console.WriteLine("Enter Member Name: ");
            string memberName = CheckNames();

            Console.WriteLine("Enter Coach Name: ");
            string coachName = CheckNames();

            Console.WriteLine("Enter Duration (in minutes): ");
            int duration = CheckDuration();

            Console.WriteLine("Enter Booking Status: ");
            string status = CheckBookingStatus();



        }
        static void ShowBookings(List<Bookings> allBookings)
        {
            foreach(Bookings booking in allBookings)
            {
                booking.ShowBookingDetails();
            }
        }
        static void AddAccessPass(List<Passes> passes)
        {
            Console.WriteLine("Enter Access Pass ID: ");
            int passID = CheckPassID(passes);

            Console.WriteLine("Enter Member ID: ");
            

        }
        static void ShowAccessPasses(List<Passes> passes)
        {
            foreach(Passes pass in passes)
            {
                pass.DisplayPassInfo();
            }
        }


        
        //Validation methods

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
        static string CheckNames()
        {
            while (true)
            {
                if(string.IsNullOrWhiteSpace(Console.ReadLine()))
                {
                    Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                    continue;
                }
                return Console.ReadLine();
            }
        } //missing character check
        static int CheckAge()
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
        static int CheckMonths()
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int givenMonths))
                {
                    Console.WriteLine("Enter a number only.");
                    continue;
                }
                return givenMonths;
            }
        }
        static string CheckStatus()
        {
            string givenStatus = Console.ReadLine();

            while (true)
            {
                if (givenStatus == "Active" || givenStatus == "Paused" || givenStatus == "Cancelled")
                {
                    return givenStatus;
                }
                else
                {
                    Console.WriteLine("Invalid status. Please enter 'Active', 'Paused', or 'Cancelled'.");

                }
            }
        }
        static string CheckSport()
        {
            while (true)
            {
                string givenSport = Console.ReadLine();
                
                if(givenSport == "Squash" || givenSport == "Cycling")
                {
                    return givenSport;
                }
                else
                {
                    Console.WriteLine("Invalid sport type. Please enter 'Squash' or 'Cycling'.");
                }
            }
        }
        static int CheckFee(List<Members> allmembers)
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int givenFee))
                {
                    Console.WriteLine("Enter a number only.");
                    continue;
                }
                if(givenFee < 0)
                {
                    Console.WriteLine("Fee cannot be negative. Please enter a valid fee.");
                    continue;
                }
                return givenFee;
            }
        }

        static int CheckBookingID(List<Bookings> allBookings)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int ID))
                {
                    Console.WriteLine("Enter a number only.");
                    continue;
                }
                if(allBookings.Any(bookings => bookings.BookingID == ID.ToString()))
                {
                    Console.WriteLine("Booking ID already exists. Please enter a unique Booking ID.");
                    continue;
                }
                return ID;
            }
        }
        static int CheckDuration()
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int duration)) 
                {
                    Console.WriteLine("Enter a number only.");
                    continue;
                }
                if(duration <= 0)
                {
                    Console.WriteLine("Duration must be a positive number.");
                    continue;
                }
                return duration;
            }
        }
        static string CheckBookingStatus()
        {
            while (true)
            {
                string status = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(status))
                {
                    Console.WriteLine("Booking status cannot be empty. Please enter a valid status.");
                    continue;
                }
                if(status ==  "Active" || status == "Paused"  || status == "Cancelled")
                {
                    return status;
                }
                else
                {
                    Console.WriteLine("Invalid booking status. Please enter 'Active', 'Paused', or 'Cancelled'.");
                    continue;
                }
            }
        }
      
        static int CheckPassID(List<Passes> passes)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int passID))
                {
                    Console.WriteLine("Enter a numeric ID");
                    continue;
                }
                if (passes.Any(pass => pass.PassID == passID))
                {
                    Console.WriteLine("Pass ID already exists. Please enter a unique Pass ID.");
                    continue;
                }
                return passID;
            }
        }

        static void StartGymFloorActivities()
        {
            Thread personalThread = new Thread(PersonalTrainingActivity.PersonalTrainingAct);
            Thread fitnessThread = new Thread(FitnessAssesmentActivity.FitnessAssesmentAct);
            Thread rehabilitationThread = new Thread(RehabilitationActivity.RehabilitationAct);

            personalThread.Start();
            fitnessThread.Start();
            rehabilitationThread.Start();

            personalThread.Join();
            fitnessThread.Join();
            rehabilitationThread.Join();
        }

        
     


    }
}
