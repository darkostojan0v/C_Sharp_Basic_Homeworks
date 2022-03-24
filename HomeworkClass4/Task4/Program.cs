using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create four methods for calculation sum, substract, multiplication and division of two numbers.
            //Create a function called calculator, that has three parameters. The first one is operator and then two numbers.
            //Depending on the value of the operator, call the corresponding function from the four ones from above.

            string operation;
            double num1;
            double num2;
            string result;

            Console.WriteLine("Enter your first number:");
            while(!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine("Enter your second number:");
            while(!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine("Enter your operator (+, -, x, /)");
            operation = Console.ReadLine();
            result = Calculator(num1, num2, operation);
            Console.WriteLine(result);
            
        }

        static string Calculator(double num1, double num2, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = Sum(num1, num2);
                    break;

                case "-":
                    result = Substract(num1, num2);
                    break;

                case "x":
                    result = Multiplication(num1, num2);
                    break;

                case "/":
                    result = Division(num1, num2);
                    break;

                default:
                    return "Invalid format!";
            }
            return $"{num1} {operation} {num2} = {result}";
        }

        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        static double Substract(double num1, double num2)
        {
            return num1 - num2;
        }s
        static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}