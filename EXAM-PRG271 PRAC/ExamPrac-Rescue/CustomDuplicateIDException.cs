using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_Rescue
{
    internal class CustomDuplicateIDException: Exception
    {

        public CustomDuplicateIDException(string message): base(message)
        {

        }
    }
}
