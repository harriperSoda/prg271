using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public abstract class ArcadeMachine
    {
        public int MachineID { get; set; }
        public string GameName { get; set; }


        public ArcadeMachine(int MachineID, string GameName)
        {
            this.MachineID = MachineID;
            this.GameName = GameName;
        }

        public abstract void StartGame();
    }
}
