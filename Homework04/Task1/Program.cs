using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a method called AgeCalculator
            //The method will have one input parameter, your birthday date
            //The method should return your age
            //Show the age of a user after he inputs a date

            DateTime birthDate = new DateTime(1996, 12, 13);
            int age = (int)Math.Floor((DateTime.Now - birthDate).TotalDays / 365.25);
            Console.WriteLine($"I am {age} years old.");

            AgeCalculator(age);

        }

        static void AgeCalculator(int age)
        {
            Console.WriteLine("Please enter your birth year.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;
            Console.WriteLine($"Now is {currentYear} year.");
            age = currentYear - userInput;
            Console.Write($"You are {age} years old.");
        }
    }
}
