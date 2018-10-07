using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Iterations
    {
        public void Task1()
        {
            var count = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine("Count of number divisible by 3 is: " + count);
        }

        public void Task2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Please enter your number: ");
                var input = Console.ReadLine();

                if (input == "ok")
                    break;

                sum += Convert.ToInt32(input);

            }
            Console.WriteLine(sum);
        }

        public void Task3()
        {
            Console.Write("Please enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var result = 1;
            for (int i = 1; i < input+1; i++)
            {
                result = result * i;
            }
            Console.WriteLine("Factorial of {0} is " + result, input);

        }

        public void Task4()
        {
            Random randomizer = new Random();
            var guess = randomizer.Next(1, 10);

            Console.Write("Secret number is:" + guess);
            

            for (int i = 0; i <4; i++)
            {
                Console.Write("Please guess a number between 1 and 10: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == guess)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    Console.Write("This is not correct number. Choose different number: ");
                }
            }
        }

        public void Task5()
        {
            Console.Write("Enter comma separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);
            foreach (var str in numbers)
            {
                var digit = Convert.ToInt32(str);
                if (digit > max)
                    max = digit;
            }

            Console.WriteLine("Maximum value number is: " + max);

        }
    }
}
