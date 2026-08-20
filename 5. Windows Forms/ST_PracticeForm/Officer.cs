using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_PracticeForm
{
    internal class Officer : CrewMember
    {

        //properties
        public string Rank { get; set; }
        public string Position { get; set; }

        //constructor
        public Officer(int Id, string Name, string Role, string Rank, string Position) : base(Id, Name, Role)
        {
            this.Rank = Rank;
            this.Position = Position;
        }

        //call abstract methid but with own implementation
        public override void PerformDuty()
        {
            Console.WriteLine($"Officer ID: {Id}, Name: {Name}, Rank: {Rank}, Position: {Position}");

        }
    }
}
