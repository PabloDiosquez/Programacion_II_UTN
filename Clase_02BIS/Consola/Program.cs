using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("°Celsius:");

            string celsius = Console.ReadLine();

            Console.WriteLine($"Celsius: {celsius} -- Fahrenheit: {ConvertirCelsiusAFahrenheit(celsius)}");
        }

        public static double ConvertirCelsiusAFahrenheit(string temperaturaCelsius)
        {
            // Convierte a double para realizar cálculos.

            double celsius = Double.Parse(temperaturaCelsius);

            // Covierte grados Celsius a Farenheit.

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }
    }
}

