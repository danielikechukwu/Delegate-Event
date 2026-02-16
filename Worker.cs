using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Event
{

    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler workPerformed;

        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            //Raising event
        }
    }

    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}
