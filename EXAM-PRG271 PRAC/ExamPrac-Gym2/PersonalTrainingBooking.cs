using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal class PersonalTrainingBooking: Bookings
    {
        public PersonalTrainingBooking(string bookingID, string memberName, string coachNmae, int duration, string bookingStatus): base(bookingID, memberName, coachNmae, duration, bookingStatus)
        {

        }

        public override void StartBooking()
        {
            Console.WriteLine("Starting one-one-one training session");
        }

    }
}
