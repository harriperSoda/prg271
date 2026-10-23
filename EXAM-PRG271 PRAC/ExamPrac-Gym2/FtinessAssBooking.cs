using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal class FtinessAssBooking: Bookings
    {
        public FtinessAssBooking(string bookingID, string memberName, string coachName, int duration, string bookingStatus) : base(bookingID, memberName, coachName, duration, bookingStatus)
        {
        }

        public override void StartBooking()
        {
            Console.WriteLine("Starting fitness and body composition assessment.");
        }
    }
}
