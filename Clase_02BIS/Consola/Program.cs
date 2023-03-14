using System;
using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("°Celsius:");

            //string celsius = Console.ReadLine();

            //Console.WriteLine($"Celsius: {celsius} -- Fahrenheit: {ConvertirCelsiusAFahrenheit(celsius)}");

            /* Llamo al método estático CotizarVentaDolares de la clase Cotizador.
             Le paso entre paréntesis el único argumento que recibe, que es el monto de dólares a vender.

             El método retorna un valor de tipo decimal que es el monto en pesos. 
             Lo guardo en una variable. 
            */

            //decimal pesos = Entidades.Cotizador.CotizarVentaDolares(100); // Sin la directiva using...

            //decimal pesos = Cotizador.CotizarVentaDolares(100);

            //Console.WriteLine(pesos);

            // Usando la clase Validador

            // Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente
            // que estén dentro del rango -100 y 100.

            //int minimo = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Número:");

            //    int numero = int.Parse(Console.ReadLine());

            //    if (Validador.Validar(numero, -100, 100))
            //    {
            //        Console.WriteLine($"El número {numero} está dentro del rango [-100, 100].");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("El número NO está dentro del rango considerado.");
            //    }

            //    // Mínimo 

            //    if (i == 0)
            //    {
            //        minimo = numero;
            //    }
            //    else
            //    {
            //        if (numero < minimo)
            //        {
            //            minimo = numero;
            //        }
            //    }
            //}

            //Console.WriteLine($"Mínimo: {minimo}");


            // Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.


            // Ejercicio I02 - ¿Desea continuar?

            Console.WriteLine($"Suma: {SumaNumeros()}");
        }

        public static double ConvertirCelsiusAFahrenheit(string temperaturaCelsius)
        {
            // Convierte a double para realizar cálculos.

            double celsius = Double.Parse(temperaturaCelsius);

            // Covierte grados Celsius a Farenheit.

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static int SumaNumeros()
        {
            int suma = 0;

            do
            {
                Console.WriteLine("Número:");

                suma += int.Parse(Console.ReadLine());


            } while (Validador.ValidarRespuesta());

            return suma;
        }
    }
}

