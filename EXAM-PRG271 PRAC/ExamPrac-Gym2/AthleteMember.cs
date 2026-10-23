using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal class AthleteMember: Members
    {
        public string SportType { get; set; }

        public AthleteMember(int memberID, string memberName, int memberAge, int membershipMonths, string currentStatus, string sportType) : base(memberID, memberName, memberAge, membershipMonths, currentStatus)
        {
            this.SportType = sportType;
        }

        public override void DisplayMemberInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Member Name: {MemberName}");
            Console.WriteLine($"Member Age: {MemberAge}");
            Console.WriteLine($"Membership Months: {MembershipMonths}");
            Console.WriteLine($"Current Status: {CurrentStatus}");
            Console.WriteLine($"Sport Type: {SportType}");
        }

        public override void EnteringGym()
        {
            Console.WriteLine("Athlete performance area access granted.");
        }
    }
}
