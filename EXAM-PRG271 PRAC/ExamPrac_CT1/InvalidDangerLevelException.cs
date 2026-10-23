using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class InvalidDangerLevelException: Exception
    {
        public InvalidDangerLevelException(string message ): base (message) //base means call constructor of parent class: Exception. Pass message top that class
        {
        }
    }
}
