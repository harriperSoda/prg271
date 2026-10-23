using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymExamPrac
{
    internal class Powerlifter: GymMembers
    {
        public double bestSquatKg { get; set; }

        public Powerlifter(int memberID, string memberName, int memberAge, string membershipType, double bestSquatKg): base(memberID, memberName, memberAge, membershipType)
        {
            this.bestSquatKg = bestSquatKg;
        }

        public override void DisplayMemberDetails()
        {
            Console.WriteLine($"Member ID: {memberID}, Member Name: {memberName}, Member Age: {memberAge}, Membership Type: {membershipType}, Best Squat (kg): {bestSquatKg}");
        }
    }
}
