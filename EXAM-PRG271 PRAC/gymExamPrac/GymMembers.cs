using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymExamPrac
{
    internal abstract class GymMembers
    {
        //creation of object propeties
        public int memberID { get; set; }
        public string memberName { get; set; }
        public int memberAge { get; set; }
        public string membershipType { get; set; }

        //creation of constructor
        public GymMembers(int memberID, string memberName, int memberAge, string membershipType)
        {
            //we assign the incoming value from the constructor to the object propeties declared above
            this.memberID = memberID;
            this.memberName = memberName;
            this.memberAge = memberAge;
            this.membershipType = membershipType;
        }

        public abstract void DisplayMemberDetails();
        //public so that method can be accessed from other classes
        //abstract so that the method can be implemented in the derived classes with their own implementation
        //void so that the method does not return any value
    }
}
