using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    internal class Smartphone
    {
        //ideally fields should be private. We controll acees to them via enapsuation or getters and setters
        private string model;
        private int battery;

        //Here we are using properties to control access to the fields. We can also use auto-implemented properties                                                     
        public int Battery
        {
            get //this just returns the value of the battery field. We can also add logic here to control access to the field
            {
                return battery;
            }
            set //this sets the value of the battery field. We can also add logic here to control access to the field
            {
                battery = value;
            }
        }
    }
}
