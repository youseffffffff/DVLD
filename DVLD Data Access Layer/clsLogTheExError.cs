using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Access_Layer
{
    public class clsLogTheExError
    {

        public static void LogError(string exMessage)
        {
            // Specify the source name for the event log
            string sourceName = "DVLD";

            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
                EventLog.CreateEventSource(sourceName, "Application");

            // Log an information event
            EventLog.WriteEntry(sourceName, exMessage, EventLogEntryType.Error);
        }
    }
}
