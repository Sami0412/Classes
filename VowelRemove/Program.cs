using System;
using System.Collections.Generic;

//https://www.codewars.com/kata/5547929140907378f9000039/solutions/csharp

namespace VowelRemove
{
    internal class Program
    {
        public class Kata
        {
            public string Shortcut(string input)
            {
                var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

                string output = "";

                for (int i = 0; i < input.Length; i++)
                {
                    if (!vowels.Contains(input[i]))
                    {
                        output += input[i];
                    }
                }

                return output;
            }
        }

        static void Main(string[] args)
        {
            var kata = new Kata();
            string output = kata.Shortcut("complain");
            Console.WriteLine(output);
        }
    }
}
