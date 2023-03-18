using System;

namespace CalculatorConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("🟥 Console Calculator in C# 🟥");

            Console.WriteLine("----------------------------");

            while (!endApp)
            {
                string numInput1 = string.Empty;

                string numInput2 = string.Empty;

                double result = double.NaN;

                Console.WriteLine("Type a number, and then press Enter: ");

                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;

                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("This is not valid input.");

                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Type a number, and then press Enter: ");

                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;

                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("This is not valid input.");

                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.

                Console.WriteLine("Choose an operator from the following list: ");

                Console.WriteLine("\ta - Add");

                Console.WriteLine("\ts - Subtract");

                Console.WriteLine("\tm - Multiply");

                Console.WriteLine("\td - Divide");

                Console.WriteLine("Your option?");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);

                    if (double.IsNaN(result)) 
                    {
                        Console.WriteLine("This operation will result in a mathematical error.");
                    }

                    Console.WriteLine("Your result: {0:0.##}", result);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("An exception ocurred trying to do the math.\nDetails: {0}",ex.Message);
                }

                Console.WriteLine("-------------------------\n");

                Console.WriteLine("Press 'n' and Enter to close the App.");

                if (Console.ReadLine().ToLower() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.

            }
        }
    }
}
