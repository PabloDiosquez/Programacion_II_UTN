using System;
using Biblioteca_I02;

namespace Presentacion_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");

            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Asegúrese de ingresar un número entero... Intente de nuevo:");
            }

            Console.WriteLine($"\nLa cantidad de dígitos de {numero} es: {numero.ContadorDigitos()}");

            Console.WriteLine("\nPrograma finalizado ✌");
        }
    }
}
