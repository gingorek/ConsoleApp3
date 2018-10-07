using System;
using System.IO;

namespace ConsoleApp3.FilesTasks
{
    public class FileTask1
    {
        public static void Task1Execution()
        {
            var path = @"E:\copytask\mytext.txt";
            var str = File.ReadAllText(path);

            var words = str.Split(' ');
            var numberOfWords = words.Length;

            Console.WriteLine(numberOfWords);
        }
    }
}