using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymExamPrac
{
    internal class MobilitySession: Sessions
    {
        public string objective { get; set; }

        public MobilitySession(int sessionID, string sessionName, int sessionDurationMin, string sessionDifficulty, string sessionCompletionStatus, string objetive): base(sessionID, sessionName, sessionDurationMin, sessionDifficulty, sessionCompletionStatus)
        {
            this.objective = objetive;
        }

        public override void DisplaySessionDetails()
        {
            Console.WriteLine($"This is a mobility session with the following details: \nSession ID: {sessionID} \nSession Name: {sessionName} \nSession Duration (min): {sessionDurationMin} \nSession Difficulty: {sessionDifficulty} \nSession Completion Status: {sessionCompletionStatus} \nObjective: {objective}");
        }
    }
}
