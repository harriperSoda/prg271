using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal class StandardMember: Members
    {

        public double MonthlyFee { get; set; } 

        public StandardMember(int memberID, string memberName, int memberAge, int membershipMonths, string currentStatus, double monthlyFee): base (memberID, memberName, memberAge, membershipMonths, currentStatus)
        {
            this.MonthlyFee = monthlyFee;

        }

        public override void DisplayMemberInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Member Name: {MemberName}");
            Console.WriteLine($"Member Age: {MemberAge}");
            Console.WriteLine($"Membership Months: {MembershipMonths}");
            Console.WriteLine($"Current Status: {CurrentStatus}");
            Console.WriteLine($"Monthly Fee: {MonthlyFee}");
        }

        public override void EnteringGym()
        {
            Console.WriteLine("Standard gym access granted.");
        }
    }
}
