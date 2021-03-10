using System;
using System.Collections.Generic;

namespace VogCodeChallenge.console
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionClass.NamesList.ForEach(name => Console.WriteLine(name));
            try
            {
                var result = QuestionClass.TESTModule(0);
                Console.WriteLine(result);
            } catch(ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange);
            }
 
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

        public static object TESTModule(object input)
        {
            switch(input)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    return (int)input * 2;
                case int value when value > 4:
                    return value * 3;
                case int value when value < 1:
                    throw new ArgumentOutOfRangeException();
                case float value when ( value == 1.0f || value == 2.0f ):
                    return 3.0f;
                case string value:
                    return value.ToUpper();
                default:
                    return input;
            }
        }
    }

}
