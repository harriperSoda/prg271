using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gymExamPrac
{
    internal abstract class Sessions
    {
        public int sessionID { get; set; }
        public string sessionName { get; set; }
        public int sessionDurationMin { get; set; }
        public string sessionDifficulty { get; set; }
        public string sessionCompletionStatus { get; set; }

        public Sessions(int sessionID, string sessionName, int sessionDurationMin, string sessionDifficulty, string sessionCompletionStatus)
        {
            this.sessionID = sessionID;
            this.sessionName = sessionName;
            this.sessionDurationMin = sessionDurationMin;
            this.sessionDifficulty = sessionDifficulty;
            this.sessionCompletionStatus = sessionCompletionStatus;
        }

        public abstract void DisplaySessionDetails();

    }
}
