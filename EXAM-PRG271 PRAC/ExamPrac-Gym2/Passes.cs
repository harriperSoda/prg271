using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal class Passes
    {
        public int PassID { get; set; }
        public int MemberID { get; set; }
        public string AccessZone { get; set; }
        public int ExpiryDays { get; set; }
        public string PassStatus { get; set; }

        public Passes(int passID, int memberID, string accessZone, int expiryDays, string passStatus)
        {
            PassID = passID;
            MemberID = memberID;
            AccessZone = accessZone;
            ExpiryDays = expiryDays;
            PassStatus = passStatus;
        }

        public void DisplayPassInfo()
        {
            Console.WriteLine($"Pass ID: {PassID}");
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Access Zone: {AccessZone}");
            Console.WriteLine($"Expiry Days: {ExpiryDays}");
            Console.WriteLine($"Pass Status: {PassStatus}");
        }
    }
}
