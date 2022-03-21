using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a console application called SumOfEven. Inside it create an array of 6 integers. Find and print the sum of the even numbers from the array:

            int[] sumOfEven = new int[] { 4, 3, 7, 3, 2, 8 };


            int even = 0;

            for(int i = 0; i < sumOfEven.Length; i++)
            {
                if (sumOfEven[i] % 2 == 0)
                {
                    even += sumOfEven[i];
                }
            }
            Console.WriteLine($"The sum of the even numbers in the array is: {even}");
        }
    }
}
