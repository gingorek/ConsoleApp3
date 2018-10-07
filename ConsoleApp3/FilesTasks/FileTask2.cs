using System;
using System.IO;

namespace ConsoleApp3.FilesTasks
{
    public class FileTask2
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public static void Task2Execution()
        {
            var path = @"E:\copytask\mytext.txt";
            var str = File.ReadAllText(path);

            Console.WriteLine("Longest word is : " + FindLongest(str));
            Console.ReadKey();
        }

        public static string FindLongest(string input)
        {
            var words = input.Split(' ');
            var charCount = 0;
            var longestWord = "";

            foreach (var word in words)
            {
                if (word.Length > charCount)
                {
                    charCount = word.Length;
                    longestWord = word;
                }
            }
            return longestWord;
        }


    }
}