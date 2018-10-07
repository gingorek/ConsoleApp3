using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class ArraysAndLists
    {
        public void Task1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Please enter names: ");
                var input = Console.ReadLine();

                if (input == String.Empty)
                    break;
                names.Add(input);
            }

            if (names.Count == 0)
                Console.WriteLine("");
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post", names[0]);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} likes your post", names[0], names[1]);
            else
                Console.WriteLine("{0}, {1} and {2} likes your post", names[0], names[1], names.Count - 2);
        }

        public void Task2()
        {
            Console.Write("Please enter your name: ");
            var input = Console.ReadLine();

            var arrayOfLetters = new char[input.Length];
            Console.WriteLine(input.Length);

            for (int i = input.Length; i > 0; i--)
            {
                arrayOfLetters[input.Length - i] = input[i];
            }
        }

        public void Task3()
        {
            var count = 0;
            var numbersList = new List<int>();

            while (count < 5)
            {
                Console.Write("Enter a number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbersList.Contains(input))
                    Console.Write("Number was entered previously. ");
                else
                {
                    numbersList.Add(input);
                    count++;
                }
            }
            numbersList.Sort();
            foreach (var number in numbersList)
            {
                Console.WriteLine(number);
            }
        }

        public void Task4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or write \"Quit\" to exit: ");
                var userInput = Console.ReadLine();
                if (userInput.ToLowerInvariant() == "quit")
                    break;
                else
                {
                    var convertedInput = int.Parse(userInput);
                    numbers.Add(convertedInput);
                }
            }
            var distinctNumbers = numbers.Distinct();

            foreach (var number in distinctNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public void Task5()
        {
            string[] strArray;
            while (true)
            {
                Console.Write("Please enter a list of numbers separated by comma: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    strArray = input.Split(',');
                    if (strArray.Count() >= 5)
                        break;
                }
                Console.WriteLine("Invalid List. ");
            }

            var numbers = new List<int>();
            foreach (var str in strArray)
            {
                numbers.Add(Convert.ToInt32(str));
            }

            numbers.Sort();
            var firstThree = numbers.Take(3);
            foreach (var num in firstThree)
            {
                Console.WriteLine(num);
            }
        }
    }
}
