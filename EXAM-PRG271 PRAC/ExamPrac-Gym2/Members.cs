using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal abstract class Members
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public int MemberAge { get; set; }
        public int MembershipMonths { get; set; }
        public string CurrentStatus { get; set; }

        public Members(int memberID, string memberName, int memberAge, int membershipMonths, string currentStatus)
        {
            this.MemberID = memberID;
            this.MemberName = memberName;
            this.MemberAge = memberAge;
            this.MembershipMonths = membershipMonths;
            this.CurrentStatus = currentStatus;
        }

        public abstract void DisplayMemberInfo();
        public abstract void EnteringGym();
    }
}
