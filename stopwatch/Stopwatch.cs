using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime StartTime;
        private DateTime EndTime;

        public DateTime Start()
        {
            StartTime = DateTime.Now;
            return StartTime;
        }

        public TimeSpan Stop()
        {
            EndTime = DateTime.Now;
            return EndTime - StartTime;
        }
    }
}