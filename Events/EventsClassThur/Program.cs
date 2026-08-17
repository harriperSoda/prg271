using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsClassThur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event obj = new Event();
            obj.buildHighway();


            //subscribe method events
            SendMail mail = new SendMail(); //creates objects from said mail class, which is out subscriber
            obj.sendEvent += mail.contactContractor;

            SendText text = new SendText();
            obj.sendEvent += text.contactContractor;

            obj.contactContractor();
            Console.ReadLine();
        }
    }
}
//
