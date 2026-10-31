using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Airport
{
    internal class InvalidSelectionCustomException: Exception
    {
        public InvalidSelectionCustomException(string message): base(message)
        {

        }
    }
}
