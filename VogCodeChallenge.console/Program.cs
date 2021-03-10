using System;
using System.Collections.Generic;

namespace VogCodeChallenge.console
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionClass.NamesList.ForEach(name => Console.WriteLine(name));
        }
    }

    public static class QuestionClass
    {
        public static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John"
        };
    }

}
