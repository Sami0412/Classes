using System;
using System.Dynamic;

namespace stopwatch
{
    public class Stopwatch
    {
        public static DateTime StartTime { get; private set; }
        public static DateTime EndTime { get; private set; }

        public static DateTime Start()
        {
            StartTime = DateTime.Now;
            return StartTime;
        }

        public static DateTime Stop()
        {
            EndTime = DateTime.Now;
            return EndTime;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'start' to start the stopwatch: ");
            if (Console.ReadLine() == "start")
            {
                Stopwatch.Start();
            }

            Console.WriteLine("Enter 'stop' to stop the stopwatch: ");
            if (Console.ReadLine() == "stop")
            {
                Stopwatch.Stop();
            }

            TimeSpan duration = Stopwatch.EndTime - Stopwatch.StartTime;
            Console.WriteLine(duration);
        }
    }
}
