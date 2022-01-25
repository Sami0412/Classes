using System;
using System.Reflection;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

        private int _upVotes;
        private int _downVotes;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedOn = DateTime.Now;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}