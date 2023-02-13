using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Texto:");
            string texto = Console.ReadLine();

            Console.WriteLine($"Cantidad de palabras: {texto.ContarPalabras()}");
            // Puedo invocarlos también como cualquier método estátco...

            int cantidadDePalabras = StringExtendido.ContarPalabras(texto);

            Console.WriteLine($"Cantidad de palabras: {cantidadDePalabras}");

        }
    }
}
