using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracPrac_Hiking1
{
    internal class DuplicateIDException: Exception
    {
        public DuplicateIDException(string message): base(message)
        {

        }
    }
}
