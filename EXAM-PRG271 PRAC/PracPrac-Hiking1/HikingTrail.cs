using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracPrac_Hiking1
{
    internal abstract class HikingTrail //abstract as we have other trails that will inherit a group of shared characteristics
    {
        public int TrailID { get; set; }
        public string TrailName { get; set; }
        public double Distance { get; set; }
        public string Difficulty { get; set; }
        public int Duration { get; set; }

        //Constructor for this class - when called it expects the following parametres
        public HikingTrail(int trailID, string trailName, double distance, string difficulty, int duration)
        {
            TrailID = trailID;
            TrailName = trailName;
            Distance = distance;
            Difficulty = difficulty;
            Duration = duration;
        }

        public abstract void StartTrail();
        public abstract void DisplayTrail();
    }
}
