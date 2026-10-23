using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal class StudentMember: Members
    {
        public string InstitutionName { get; set; }

        public StudentMember(int memberID, string memberName, int memberAge, int membershipMonths, string currentStatus, string instituitionName): base (memberID, memberName, memberAge, membershipMonths, currentStatus)
        {
            this.InstitutionName = instituitionName;
        }

        public override void DisplayMemberInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Member Name: {MemberName}");
            Console.WriteLine($"Member Age: {MemberAge}");
            Console.WriteLine($"Membership Months: {MembershipMonths}");
            Console.WriteLine($"Current Status: {CurrentStatus}");
            Console.WriteLine($"Institution Name: {InstitutionName}");
        }

        public override void EnteringGym()
        {
            Console.WriteLine("Student membership verified. Access granted.");
        }
    }
}
