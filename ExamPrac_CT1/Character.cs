using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac_CT1
{
    internal abstract class Character
    {
        public int id { get; set;  }
        public string name { get; set; }
        public int age { get; set; }
        public int strengthLevel { get; set; }

        public Character(int id,  string name, int age, int strengthLevel)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.strengthLevel = strengthLevel;
        }

        public abstract void callCharacter();
        //public so method can be called from outside class
        //abstract because the parent class does not provide implementation. Child classes do that
        //void as it does not return a value
    }
}
