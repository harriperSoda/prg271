using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsClassThur
{
    internal class Event
    {

        public void buildHighway()
        {
            Console.WriteLine("Build highway N3...");
            Console.WriteLine("===");
            Console.WriteLine("Head of sub-contractor??");
            Console.WriteLine();
        }
        //creation of delegate(contract)
        public delegate void contractContracterHandler();

        //create an event based on that delegate
        public event contractContracterHandler sendEvent;

        public void contactContractor()
        {
            if (sendEvent != null)
            {
                sendEvent();
            }
        }
    }
}
