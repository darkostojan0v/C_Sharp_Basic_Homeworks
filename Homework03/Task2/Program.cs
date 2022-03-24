using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take a sentence as input and find its words.

            Console.WriteLine("Input a sentence which contains 'SEDC'.");
            string userInput = Console.ReadLine();

            Console.WriteLine(userInput.Contains("SEDC"));
        }
    }
}
