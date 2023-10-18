using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Texto:");
            //string texto = Console.ReadLine();

            //Console.WriteLine($"Cantidad de palabras: {texto.ContarPalabras()}");

            //// Puedo invocarlos también como cualquier método estátco...
            //int cantidadDePalabras = StringExtendido.ContarPalabras(texto);

            //Console.WriteLine($"Cantidad de palabras: {cantidadDePalabras}");

            string texto1 = "Nosotros no somos como los Orozco. Stop, stop, stop.";

            Console.WriteLine($"Cantidad de apariciones de la palabra 'stop': {texto1.ContarApariciones("stop")}");
        }
    }
}
