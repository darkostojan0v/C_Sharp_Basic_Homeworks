using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of ten numbers.
            //Use LINQ to select in a list of the squares of all the numbers in the list from above.

            List<int> listOfNumbers = new List<int> { 3, 5, 12, 27, 46, 7, 33, 24, 18, 40 };

            List<int> listOfSquaredNumbers = listOfNumbers.Select(x => x * x).ToList();

            Console.WriteLine("Square of every number from the list, starting from first to last.");
            foreach (int item in listOfSquaredNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
