using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class TimeTrackerStopWatch : Stopwatch
    {
        public TimeSpan StartOffset { get; private set; }

        public TimeTrackerStopWatch(TimeSpan startOffset)
        {
            StartOffset = startOffset;
        }

        public new long ElapsedMilliseconds
        {
            get
            {
                return base.ElapsedMilliseconds + (long)StartOffset.TotalMilliseconds;
            }
        }

        public new TimeSpan Elapsed => base.Elapsed + StartOffset;


        public new long ElapsedTicks
        {
            get
            {
                return base.ElapsedTicks + StartOffset.Ticks;
            }
        }

    }
}
