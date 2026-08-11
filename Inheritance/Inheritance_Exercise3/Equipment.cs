using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise3
{
    internal class Equipment
    {
        public DateTime acquireDate { get; set; }
        public string propetyID { get; set; }

        public Equipment(DateTime acquireDate, string propetyID)
        {

        
            this.acquireDate = acquireDate;
            this.propetyID = propetyID;
        }
        
    }
}
