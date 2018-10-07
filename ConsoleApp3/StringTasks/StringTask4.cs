using System;

namespace ConsoleApp3
{
    public class StringTask4
    {
        public static void Task4Execution()
        {
            Console.Write("Write a few lines: ");
            var input = Console.ReadLine().Split(' ');

            var str = ChangeToPascalCase(input);
            Console.WriteLine(str);
        }

        public static string ChangeToPascalCase(string[] input)
        {
            var resultString = "";
            foreach (var word in input)
            {
                var toPacalCase = word[0].ToString().ToUpper() + word.ToLower().Substring(1);
                resultString += toPacalCase;
            }
            return resultString;
        }
    }
}