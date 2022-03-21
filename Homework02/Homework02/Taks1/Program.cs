using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “FindStatistics”. Input 2 numbers.If the two of them are even, print their sum, if one of them is odd, print their difference, if the two off them are odd, multiply them. Don't print just the result, but also the whole operation. Treat zero as even.

            int num1, num2;

            Console.Write("Enter the First Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0 && num2 % 2 == 0)
            {
                Console.WriteLine($"Both numbers are even. The operation is {num1} + {num2} and result is: {num1 + num2}");
            }
            else if(num1 % 2 == 0 && num2 % 2 == 1 || num1 % 2 == 1 && num2 % 2 == 0)
            {
                Console.WriteLine($"One number is even and the other is odd. The operation is {num1} - {num2} and result is: {num1 - num2}");
            }
            else if(num1 % 2 == 1 && num2 % 2 == 1)
            {
                Console.WriteLine($"Both numbers are odd. The operation is {num1} * {num2} and result is {num1 * num2}");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
