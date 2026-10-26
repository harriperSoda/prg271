using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracPrac_Hiking1
{
    internal class MountainTrail: HikingTrail //Inherit from parent class

    {
        //an abstract class so it can provide it own logic
        public double ElevationGain { get; set; } 

        //Constructor for this class - when called it expects the following parametres. When recieved it will pass them to the base class constructor to be set and assign the values to the properties of the class
        public MountainTrail(int trailID, string trailName, double distance, string difficulty, int duration, double ElevationGain): base (trailID, trailName, distance, difficulty, duration)
        {
            
            this.ElevationGain = ElevationGain;

        }

        public override void StartTrail()
        {
            throw new NotImplementedException();
        }

    }
}
