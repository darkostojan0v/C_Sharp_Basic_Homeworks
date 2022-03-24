using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take one string from the input and print its last 5 characters.

            Console.WriteLine("Welcome, please input your favourite quote.");
            string inputFromUser = Console.ReadLine();

            string fiveLastCharacters = inputFromUser.Substring(inputFromUser.Length - 5);

            Console.WriteLine($"The last 5 characters from the users favourite quote are: {fiveLastCharacters}");
        }
    }
}
