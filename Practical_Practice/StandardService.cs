using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Practice
{
    internal class StandardService: RestaurantServices
    {

        //constructor
        public StandardService(int serviceNumber, int NumberofGuests, string serviceType, double timeLimit, string currentStatus) : base(serviceNumber, NumberofGuests, serviceType, timeLimit, currentStatus)
        {
        }

        public override void startService()
        {
            Console.WriteLine($"Standard service {serviceNumber} for {numberOfGuests} guests has started. Service type: {serviceType}, Time limit: {timeLimit} hours, Current status: {currentStatus}");
        }
    }
}
