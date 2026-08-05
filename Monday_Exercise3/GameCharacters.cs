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

        public GameCharacters(string characterName, string characterClassType, int characterHealth)
        {
            name = characterName;
            characterClass = characterClassType;
            health = characterHealth;

        }

        public void displayCharacter()
        {
            Console.WriteLine($"{name} is a {characterClass} with {health} health");
        }
    }
    
    }

