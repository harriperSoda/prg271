using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Gym2
{
    internal class DuplicatePassIDException: Exception //This custom exception class inherits from the base Exception class.
    {
        public DuplicatePassIDException(string message): base(message) //Constructor
        {

        }
    }
}
