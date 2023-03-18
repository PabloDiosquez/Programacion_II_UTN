using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.

            int num1 = 0, num2 = 0;

            // Display title as the C# console calculator app.

            Console.WriteLine("🔺 Console Calculator in C# 🔺");

            Console.WriteLine("-------------------------------");

            // Ask the user to type the first number.

            Console.WriteLine("Type a number, and then press Enter");

            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.

            Console.WriteLine("Type another number, and then press Enter");

            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.

            Console.WriteLine("Choose an option from the following list");

            Console.WriteLine("\ta - Add");

            Console.WriteLine("\ts - Subtract");

            Console.WriteLine("\tm - Multiply");

            Console.WriteLine("\td - Divide");

            Console.WriteLine("Your option? ");


        }
    }
}
