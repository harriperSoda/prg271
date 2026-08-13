using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracRecap
{
    public abstract class Pet
    {
        public int petID { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        //constructor

        public Pet(int petID, string name, int age)
        {
            this.petID = petID;
            this.name = name;
            this.age = age;

        }

        public abstract void PetInfo();

    }
}
