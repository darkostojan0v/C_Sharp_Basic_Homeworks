using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Methods
{
    internal class UserInput
    {
        internal static string GetFirstName()
        {
            Console.WriteLine("Please enter your first name:");
            string name = Console.ReadLine();

            return name;
        }
        internal static string GetLastName()
        {
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            return lastName;
        }
        internal static int GetAge()
        {
            Console.WriteLine("Please enter your age:");
            string age = Console.ReadLine();

            int AgeParsed = int.Parse(age);

            return AgeParsed;
        }
    }
}
