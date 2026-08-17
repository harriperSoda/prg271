using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Pinnball : ArcadeMachine

    {
        public Pinnball(int MachineID, string GameName) : base(MachineID, GameName)
        {

        }

        public override void StartGame()
        {
            Console.WriteLine($"Starting {GameName} on machine {MachineID}...");
        }
    }
}
