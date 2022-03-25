using System;
using Task2.Models;
using Task2.Methods;

namespace Task2
{ 
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonStats that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information(take first name, last name and age from user input)
            //Call the GetPersonStats method and print the result in the console after the object is created


            Human human = new Human();
            human.Age = UserInput.GetAge();
            human.FirstName = UserInput.GetLastName();
            human.LastName = UserInput.GetLastName();

            string info = human.GetPersonalStats(human.FirstName, human.LastName, human.Age);

            Console.WriteLine(info); 
            
        }
        
    }
}
