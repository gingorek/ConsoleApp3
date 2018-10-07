using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class StringTask2
    {
        public static void Task2Execution()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = MakeAListOfNumber(input);
            var hasDuplicate = CheckDuplicates(numbers);

            if (hasDuplicate)
                Console.WriteLine("Mamy Duplikat");
        }

        public static List<int> MakeAListOfNumber(string inputStr)
        {
            if (String.IsNullOrWhiteSpace(inputStr))
                return null;

            var stringArray = inputStr.Split('-');
            var numbers = new List<int>();

            foreach (var element in stringArray)
            {
                numbers.Add(Convert.ToInt32(element));
            }

            return numbers;
        }

        public static bool CheckDuplicates(List<int> numbers)
        {
            var uniqueList = new List<int>();
            var hasDuplicate = false;

            foreach (var number in numbers)
            {
                if (uniqueList.Contains(number))
                {
                    hasDuplicate = true;
                    break;
                }
                else
                    uniqueList.Add(number);
            }
            return hasDuplicate;
        }
    }
}