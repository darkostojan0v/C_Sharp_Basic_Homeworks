using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter a number as an input. Print all the numbers except the numbers divisible by 5. When you come to 80, the limit is reached.


            Console.WriteLine("Enter a number");

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                else if(i == 81)
                {
                    Console.WriteLine("You've reached the limit!");
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}
