using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Lec5_Ex1
{
    internal class Validation
    {
        public static bool ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            return true;

        }

        public static bool ValidateSurname(string surname)
        {
            if (string.IsNullOrWhiteSpace(surname))
            {
                return false;
            }
            return true;
        }

        public static bool ValidateJob(string job)
        {
            if (string.IsNullOrWhiteSpace(job))
            {
                return false;
            }
            return true;
        }
    }
}
