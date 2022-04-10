using System;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give the user an option to input 5 numbers
            //Store all numbers in a QUEUE
            //When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

            Queue<string> userInput = new Queue<string>();

            Console.WriteLine("Please enter 5 numbers separated by a comma.");

            userInput.Enqueue(Console.ReadLine());

            foreach(var item in userInput)
            {
                Console.WriteLine($"The 5 numbers you entered in order are: {item}");
            }
            
        }
    }
}
