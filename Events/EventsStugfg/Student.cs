using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventsStugfg
{
    internal class Student
    {
        public void study()
        {
            Console.WriteLine("Studying")
;
            Console.WriteLine("dI PASS");


            public delegate void studyHandler();
            public event studyHandler sendEvent;

        public void studentMark(double mark)
        {
            if (mark < 50)
            {
                sendEvent();
            }

        }
}
