using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_PracticeForm
{
    internal class CrewDataHandler
    {
        //creates a list allowing objects of type CrewMember to be stored in it
        private List<CrewMember> crewMembers = new List<CrewMember>();

        //method to add a crew member to the list
        public void PopulateCrew()
        {
            crewMembers.Add(new Officer(1, "Odyessus", "Officer", "Captain", "Command"));
            crewMembers.Add(new Sailor(2, "Eurycolus", "Sailor", "Deck"));
            crewMembers.Add(new Sailor(3, "Polites", "Sailor", "Deck"));
        }

        //need the form to access the private list so create a public method to return the list
        public List<CrewMember> getCrewMemebrs()
        {
            return crewMembers;
        }
    }
}
