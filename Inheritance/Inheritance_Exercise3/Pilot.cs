using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise3
{
    internal class Pilot:Employee
    {
        public DateTime certificationDate { get; set; }

        public Pilot(double age, string name, DateTime dateHIred, string idNumber, DateTime certificationDate):base(age, name, dateHIred, idNumber)
        {
            this.certificationDate = certificationDate;
        }
    }
}
