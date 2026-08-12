using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_FirstPracticeRun
{
    internal class Dog
    {

        public string name;
        public int age;

        //constructor --> called everytime you create a new dog
        //takes raw values and assigns them to the properties of the dog object
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
