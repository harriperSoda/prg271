using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracPrac_Hiking1
{
    internal class ForestTrail: HikingTrail
    {
        public string WildLifeRiskLevel { get; set; }
        //Constructor for this class
        public ForestTrail(int trailID, string trailName, double distance, string difficulty, int duration, string wildLifeRiskLevel): base(trailID, trailName, distance, difficulty, duration) //you will pass these bace to base class
        {
            this.WildLifeRiskLevel = wildLifeRiskLevel;
        }

        public override void StartTrail()
        {
            throw new NotImplementedException();
        }
        public override void DisplayTrail()
        {
            Console.WriteLine($"Trail ID {TrailID}");
            Console.WriteLine($"Trail Name {TrailName}");
        }
    }
}
