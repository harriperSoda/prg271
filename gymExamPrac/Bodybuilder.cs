using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymExamPrac
{
    internal class Bodybuilder: GymMembers
    {
        public int bodyBuilderWeight { get; set; }

        //creating constructor as to what the Bodybuilder class will expect and inherit
        public Bodybuilder(int memberID, string memberName, int memberAge, string membershipType, int bodybuilderWeight) : base(memberID, memberName, memberAge, membershipType) //base says, the values we got from the constructor, pass them to the parent class. Names need to match its own constructor, not parent. 
        {
            this.bodyBuilderWeight = bodybuilderWeight;
        }

        public override void DisplayMemberDetails()
        {
            Console.WriteLine($"Member ID: {memberID}, Member Name: {memberName}, Member Age: {memberAge}, Membership Type: {membershipType}, Bodybuilder Weight: {bodyBuilderWeight}");
        }
    }
}
