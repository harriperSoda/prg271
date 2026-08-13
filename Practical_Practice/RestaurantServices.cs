using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Practice
{
    public abstract class RestaurantServices
    {
        //this will be abstract class and will be inherited by other classes

        public int serviceNumber { get; set; }
        public int numberOfGuests { get; set; }
        public string serviceType { get; set; }
        public double timeLimit { get; set; } //in hours
        public string currentStatus { get; set; } //e.g. "In Progress", "Completed", "Cancelled"


        //constructor

        public RestaurantServices(int serviceNumber, int numberOFGuests, string serviceType, double timeLimit, string currentStatus)
        {
            this.serviceNumber = serviceNumber;
            this.numberOfGuests = numberOFGuests;
            this.serviceType = serviceType;
            this.timeLimit = timeLimit;
            this.currentStatus = currentStatus;

        }

        //create abstract method
        public abstract void startService();
    }
}
