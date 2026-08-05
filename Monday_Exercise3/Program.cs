using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday_Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCharacters character1 = new GameCharacters();
            character1.name = "Aragorn";
            character1.characterClass = "Ranger";
            character1.health = 100;

            character1.displayCharacter();
        }
    }
}
