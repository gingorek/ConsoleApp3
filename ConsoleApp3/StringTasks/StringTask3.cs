using System;

namespace ConsoleApp3
{
    public class StringTask3
    {
        public static void Task3Execution()
        {
            Console.WriteLine("Please enter a time in 24 format e.g.(19:00) : ");
            var input = Console.ReadLine();

            var strArray = MakeAnArray(input);
            CheckTimeFormat(strArray);
        }
        public static string[] MakeAnArray(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("invalid Time.");
            }

            var timeArray = input.Split(':');
            if (timeArray.Length != 2)
            {
                Console.WriteLine("invalid Time.");
            }
            return timeArray;
        }

        public static void CheckTimeFormat(string [] strArray)
        {
            var hour = Convert.ToInt32(strArray[0]);
            var minutes = Convert.ToInt32(strArray[1]);

            if (hour > 0 && hour <= 23 && minutes >= 0 && minutes <= 59)
            {
                Console.WriteLine("Time is ok");
            }
            else
            {
                Console.WriteLine("invalid Time");
                return;
            }
        }
        
    }
}