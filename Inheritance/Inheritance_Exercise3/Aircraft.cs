using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise3
{
    internal class Aircraft:Equipment
    {
        public string type { get; set; }
        public string tailNumber {get; set; }  

        public Aircraft(DateTime acquireDate, string propetyID, string type, string tailNumber):base(acquireDate, propetyID)
        {
            this.type = type;
            this.tailNumber = tailNumber;
        }
    }
}
