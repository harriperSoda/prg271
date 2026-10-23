using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymExamPrac
{
    internal class Runner: GymMembers
    {
        public double best5kTime { get; set; }
        public Runner(int memberID, string memberName, int memberAge, string membershipType, double best5kTime): base(memberID, memberName, memberAge, membershipType)
        {
            this.best5kTime = best5kTime;
        }
        public override void DisplayMemberDetails()
        {
            Console.WriteLine($"Member ID: {memberID}, Member Name: {memberName}, Member Age: {memberAge}, Membership Type: {membershipType}, Best 5k Time: {best5kTime}");
        }
    }
}
