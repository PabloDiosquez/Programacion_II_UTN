using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.

            double num1 = 0, num2 = 0;

            // Display title as the C# console calculator app.

            Console.WriteLine("🔺 Console Calculator in C# 🔺");

            Console.WriteLine("-------------------------------");

            // Ask the user to type the first number.

            Console.WriteLine("Type a number, and then press Enter:");

            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.

            Console.WriteLine("Type another number, and then press Enter:");

            num2 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to choose an option.

            Console.WriteLine("Choose an option from the following list");

            Console.WriteLine("\ta - Add");

            Console.WriteLine("\ts - Subtract");

            Console.WriteLine("\tm - Multiply");

            Console.WriteLine("\td - Divide");

            Console.WriteLine("Your option? ");

            // Use a switch statement to do the math.

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Your result: {0} + {1} = {2}", num1, num2, num1+num2);
                    break;
                case "s":
                    Console.WriteLine("Your result: {0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case "m":
                    Console.WriteLine("Your result: {0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.WriteLine("Your result: {0} / {1} = {2}", num1, num2, num1 / num2);
                    break;
            }

            // Wait for the user to respond before closing.
            Console.WriteLine("Press any key to close the Calculator Console App");


            Console.ReadKey();

        }
    }
}
