using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_2
{
    public abstract class Character
    {

        public int characterID { get; set; }
        public string name { get;set; }
        public int age { get; set; }
        public int strengthLevel { get; set; }

        public Character(int characterID, string name, int age, int strengthLevel)
        {
            this.characterID = characterID;
            this.name = name;
            this.age = age;
            this.strengthLevel = strengthLevel;
        }

        public abstract void SummonCharacter();
    }
}
