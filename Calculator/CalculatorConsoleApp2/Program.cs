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

                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;

                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("This is not valid input.");

                    numInput2 = Console.ReadLine();
                }
            }
        }
    }
}
