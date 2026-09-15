using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal class MissionAlreadyCompletedException: Exception
    {
        public MissionAlreadyCompletedException(string message): base(message)
        {

        }
    }
}
