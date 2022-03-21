using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30
            //Expected Output:
            //The average of 10, 15, 20 and 30 is: 18

            int firstNumber = 10;
            int secondNumber = 15;
            int thirdNumber = 20;
            int fourthNumber = 30;

            int average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

            Console.WriteLine($"The average of those four numbers is:{average}");
        }
    }
}
