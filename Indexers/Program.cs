using System;

namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Sami";
            Console.WriteLine(cookie["name"]);
        }
    }
}
