using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of integers. Get the number of elements and the values of the elements from input.
            //Find how many times there are two 3 next to each other.

            int elements;
            Console.WriteLine("Enter a numbers from 1 to 9");

            while(!int.TryParse(Console.ReadLine(), out elements))
            {
                Console.WriteLine("Invalid input!");
            }

            int[] integersArray = new int[elements];

            for(int i = 0; i < integersArray.Length; i++)
            {
                int input;
                Console.WriteLine($"Please enter value number {i + 1}:");
                while(!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input!");
                }

                integersArray[i] = input;
            }

            Console.WriteLine(Test(integersArray));
        }

        static string Test(int[] numbers)
        {
            int counter = 0;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] == 3 && numbers[i + 1] == 3)
                {
                    counter++;
                }
            }

            string name = "";

            switch (counter)
            {
                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return $"{name} times are there same numbers next to each other";
        }
    }
}
