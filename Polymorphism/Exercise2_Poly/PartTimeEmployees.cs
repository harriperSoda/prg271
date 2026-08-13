using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Poly
{
    internal class PartTimeEmployees : Employee
    {
        // 1. THE BACKING FIELD: 
        // We add an underscore (_) to private storage variables. 
        // Whenever you see the underscore, you know it's the hidden container.
        private double _hourlyRate;
        
        public int hoursWorked;

        // 2. THE PROPERTY (GATEKEEPER):
        // Starts with a Capital letter. It controls access to the _underscore variable.
        public double HourlyRate
        {
            get
            {
                return _hourlyRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hourly rate cannot be negative.");
                }
                else
                {
                    _hourlyRate = value;
                }   
            }
        }

        // 3. THE CONSTRUCTOR (INCOMING DATA):
        // I named these with the word "provided" so you can easily see they are the raw inputs coming from Program.cs.
        public PartTimeEmployees(double providedHourlyRate, int providedHoursWorked)
        {
            // Send the incoming parameter on the right into the Property gatekeeper on the left.
            this.HourlyRate = providedHourlyRate;
            
            this.hoursWorked = providedHoursWorked;
        }

        public override void CalculateSalary()
        {
            // Inside your methods, you can safely grab the data straight from the private storage
            double salary = _hourlyRate * hoursWorked;
            Console.WriteLine($"Calculating salary for PartTimeEmployee: {salary}");
        }
    }
}
