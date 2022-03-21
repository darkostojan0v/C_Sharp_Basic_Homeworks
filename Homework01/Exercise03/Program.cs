using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

            //Test Data:
            //Input the First Number: 5
            //Input the Second Number: 8
            //Expected Output:
            //After Swapping:
            //First Number: 8
            //Second Number: 5


            Console.WriteLine("Swapping numbers");

            int number1, number2, temporary;

            Console.Write("Enter the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            temporary = number1;
            number1 = number2;
            number2 = temporary;

            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First number:{0} \nSecond number:{1}", number1, number2);

        }
    }
}
