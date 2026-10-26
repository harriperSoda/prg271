using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracPrac_Hiking1
{
    internal class InvalidDistanceCustomException: Exception
    {
        public InvalidDistanceCustomException(string message): base(message)
        {

        }
    }
}
