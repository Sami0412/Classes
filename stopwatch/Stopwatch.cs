using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public DateTime Start()
        {
            try
            {
                if (StartTime == DateTime.MinValue)
                {
                    StartTime = DateTime.Now;
                    return StartTime;
                }

                throw new InvalidOperationException("Stopwatch already started!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public TimeSpan Stop()
        {
            EndTime = DateTime.Now;
            return EndTime - StartTime;
        }
    }
}