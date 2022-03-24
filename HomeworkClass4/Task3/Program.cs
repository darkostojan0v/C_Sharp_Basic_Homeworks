using System;

namespace Task3
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Create a function that takes a number as input. This method should return the sum of the digits in the number.

            int input;

            Console.WriteLine("Enter a number.");
            while(!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input, enter a number!");
            }
            GetSum(input);
        }

        private static int GetSum(int input)
        {
            int result = 0;
            while (input != 0)
            {
                result += input % 10;
                input = input / 10;
            }

            Console.WriteLine($"The sum of the digits is: {result}");
            return result;
        }
    }
}
