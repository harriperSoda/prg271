using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Practice
{
    internal class ChallengeService: RestaurantServices
    {

        //constructor
        public ChallengeService(int serviceNumber, int numberOfGuests, string serviceType, double timeLimit, string currentStatus): base(serviceNumber, numberOfGuests, serviceType, timeLimit, currentStatus)
        {
        }

        //override
        public override void startService()
        {
            Console.WriteLine($"Challenge service {serviceNumber} for {numberOfGuests} guests has started. Service type: {serviceType}, Time limit: {timeLimit} hours, Current status: {currentStatus}");
        }
    }
}
