using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new console application.
            //Create an array of 10 whole numbers(integers).
            //Find the minimum and maximum and print them in the console.

            int[] arr = new int[] { 10, 8, 21, -6, 14};

            int min = arr[0];
            int max = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"The sum of the min and the max number of the array is {min + max}");

        }
    }
}
