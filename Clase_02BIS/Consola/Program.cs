using System;
using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("°Celsius:");

            string celsius = Console.ReadLine();

            Console.WriteLine($"Celsius: {celsius} -- Fahrenheit: {ConvertirCelsiusAFahrenheit(celsius)}");

            /* Llamo al método estático CotizarVentaDolares de la clase Cotizador.
             Le paso entre paréntesis el único argumento que recibe, que es el monto de dólares a vender.

             El método retorna un valor de tipo decimal que es el monto en pesos. 
             Lo guardo en una variable. 
            */

            //decimal pesos = Entidades.Cotizador.CotizarVentaDolares(100); // Sin la directiva using...

            decimal pesos = Cotizador.CotizarVentaDolares(100); 

            Console.WriteLine(pesos);
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

