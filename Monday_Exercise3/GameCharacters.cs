using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday_Exercise3
{
    internal class GameCharacters
    {
        public string name;
        public string characterClass;
        public int health;

        public void displayCharacter()
        {
            Console.WriteLine($"{name} is a {characterClass} with {health} health");
        }
    }
    
    }

