using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO MOOD ANALYSER PROBLEM!");
            MoodAnalyse mood = new MoodAnalyse();//Creating Object
            Console.WriteLine(mood.Analyser());//calling method

        }
    }
}
