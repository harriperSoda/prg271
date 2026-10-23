using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal class RehabSessionBooking: Bookings
    {
        public RehabSessionBooking(string bookingID, string memberName, string coachNmae, int duration, string bookingStatus) : base(bookingID, memberName, coachNmae, duration, bookingStatus)
        {
        }
        public override void StartBooking()
        {
            Console.WriteLine("Starting supervised rehabilitation session.");
        }
    {
    }
}
