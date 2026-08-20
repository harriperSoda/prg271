using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_PracticeForm
{
    internal class Sailor: CrewMember
    {

        //propeties
        public string Station { get; set; }

        //constructor
        public Sailor(int Id, string Name, string Role, string Station): base(Id, Name, Role)
        {
            this.Station = Station;
        }

        //call abstract methid but with own implementation
        public override void PerformDuty()
        {
            Console.WriteLine($"Sailor ID: {Id}, Name: {Name}, Station: {Station}");
        }
    }
}
