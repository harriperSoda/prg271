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
    }
}
