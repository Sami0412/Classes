using System;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var input = "";

            while (input != "x")
            {
                Console.WriteLine("Enter 'start' to start the stopwatch, 'stop' to stop the stopwatch, or 'x' to exit: ");
                input = Console.ReadLine();
                if (input == "start")
                {
                    stopwatch.Start();
                }
                if (input == "stop")
                {
                    Console.WriteLine(stopwatch.Stop());
                }
            }
        }
    }
}
