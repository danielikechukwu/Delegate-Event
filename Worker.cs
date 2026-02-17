using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Event
{

    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;

        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for(int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i+1, workType);
                Thread.Sleep(3000);
            }

            OnWorkCompleted(); 
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            if(WorkPerformed is WorkPerformedHandler del2)
            {
                del2(8, WorkType.GenerateReports);
            }
        }

        protected virtual void OnWorkCompleted()
        {
            if(WorkCompleted is EventHandler del1)
            {
                del1(this, EventArgs.Empty);
            }
        }
    }

    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}
