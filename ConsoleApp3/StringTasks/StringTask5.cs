using System;

namespace ConsoleApp3
{
    public class StringTask5
    {
        public static void Task5Execution()
        {
            Console.WriteLine("Please write word in English: ");
            var input = Console.ReadLine();

            var vowels = CheckVowels(input);
            Console.WriteLine("number of vowels in the sentence is: " + vowels);
        }

        public static int CheckVowels(string input)
        {
            int total = 0;
            foreach (var vowel in input)
            {
                if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u') 
                    total++;
            }
            return total;
        }
    }
}