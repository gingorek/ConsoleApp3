using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class StringTask1
    {
        public static void Task1Execution()
        {
            Console.WriteLine("Enter numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            var listOfNumbers = AddNumberToList(input);
            var isConsecutive = CheckIfConsecutive(listOfNumbers);

            var message = isConsecutive ? "Consecutive" : "Non Consecutive";
            Console.WriteLine(message);
        }

        public static List<int> AddNumberToList(string input)
        {
            var stringArray = input.Split(',');
            var numberList = new List<int>();

            foreach (var str in stringArray)
            {
                var number = Convert.ToInt32(str);
                numberList.Add(number);
            }
            return numberList;
        }

        public static bool CheckIfConsecutive(List<int> numbers)
        {
            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] - 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            return isConsecutive;
        }
    }
}