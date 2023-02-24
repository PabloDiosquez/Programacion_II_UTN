using System;
using Biblioteca_Cartuchera;

namespace Consola_Cartuchera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            Console.ForegroundColor = eLapiz.Color;
            Console.WriteLine(eLapiz.Texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.Color;
            Console.WriteLine(eBoligrafo.Texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();
        }
    }
}
