using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal abstract class Bookings
    {
        public string BookingID { get; set; }
        public string MemberName { get; set; }
        public string CoachName { get; set; }
        public int Duration { get; set; }
        public string BookingStatus { get; set; }

        public Bookings(string bookingID, string memberName, string coachName, int duration, string bookingStatus)
        {
            BookingID = bookingID;
            MemberName = memberName;
            CoachName = coachName;
            Duration = duration;
            BookingStatus = bookingStatus;
        }

        public abstract void StartBooking();
        public abstract void ShowBookingDetails();
    }
}
