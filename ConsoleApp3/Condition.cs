using System;

namespace ConsoleApp3
{
    public class Condition
    {
        public void Exercise1()
        {
            Console.Write("Please enter a number: ");
            var inputNumber = Console.ReadLine();
            var number = Convert.ToInt32(inputNumber);

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Number is Valid");
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
        public void Exercise2()
        {
            Console.Write("Please enter first number: ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter second number: ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            int maxNumber = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            Console.WriteLine("max number is: " + maxNumber);

        }
        public void Exercise3()
        {
            Console.Write("Please enter length of picture: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter height of picture: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Program.PicturePosition position = (length > height) ? Program.PicturePosition.Landscape : Program.PicturePosition.Portrait;
            Console.Write("Picture orientation is: " + position);

        }
        public void Exercise4()
        {
            const int speedLimit = 50;
            Console.Write("Enter speed of your car: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < speedLimit)
            {
                Console.WriteLine("Speed is OK");
            }
            else
            {
                var demeritPoints = (userInput - speedLimit) / 5;
                if (demeritPoints > 12)
                {
                    Console.Write("Your license is suspended. ");
                }
                else
                {
                    Console.WriteLine("Speed is to high! You get " + demeritPoints + " demerit points.");
                }
            }

        }
    }
}
