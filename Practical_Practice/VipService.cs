using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Practice
{
    internal class VipService: RestaurantServices
    {
        //constructors
        public VipService(int serviceNumber, int numberOfGuests, string serviceType, double timeLimit, string currentStatus) : base(serviceNumber, numberOfGuests, serviceType, timeLimit, currentStatus)
        {

        }

        //orverride
        public override void startService()
        {
                       Console.WriteLine($"VIP service {serviceNumber} for {numberOfGuests} guests has started. Service type: {serviceType}, Time limit: {timeLimit} hours, Current status: {currentStatus}");
        }
    }
}
