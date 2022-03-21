using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the Operation: +
            //Expected Output:
            //The result is: 25

            Console.WriteLine("Enter a valid operation!");

            int firstNumber = 10;
            int secondNumber = 15;

            int enteredOperation = Convert.ToChar(Console.ReadLine());

            if (enteredOperation == '+')
            {
                Console.WriteLine($"The result is:{firstNumber + secondNumber}");
            }
            else if (enteredOperation == '-')
            {
                Console.WriteLine($"The result is:{firstNumber - secondNumber}");
            }
            else if (enteredOperation == '*')
            {
                Console.WriteLine($"The result is:{firstNumber * secondNumber}");
            }
            else if (enteredOperation == '/')
            {
                Console.WriteLine($"The result is:{firstNumber / secondNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
