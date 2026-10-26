using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracPrac_Hiking1
{
    internal class ForestTrail: HikingTrail
    {
        public int WildLifeRiskLevel { get; set; }
        //Constructor for this class
        public ForestTrail(int trailID, string trailName, double distance, string difficulty, int duration, int wildLifeRiskLevel): base(trailID, trailName, distance, difficulty, duration) //you will pass these bace to base class
        {
            this.WildLifeRiskLevel = wildLifeRiskLevel;
        }

        public override void StartTrail()
        {
            throw new NotImplementedException();
        }
    }
}
