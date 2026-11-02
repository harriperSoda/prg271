using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Lec5_Ex2
{
    internal class Validator
    {
        public static bool ValidateNameSurname(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            return true;
        }

        public static bool ValidateDOB(DateTime DOB)
        {
            if (DOB > DateTime.Today)
            {
                return false;
            }
            return true;
        }
    }
}
