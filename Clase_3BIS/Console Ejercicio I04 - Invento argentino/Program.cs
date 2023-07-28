using System;
using Ejercicio_I04___Invento_argentino;

namespace Console_Ejercicio_I04___Invento_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Agregar un proyecto de consola.
            //En el método Main, crear un bolígrafo de tinta azul(ConsoleColor.Blue) y una cantidad inicial de tinta de 100
            //y otro de tinta roja(ConsoleColor.Red) y 50 de tinta.
            //Utilizar todos los métodos y mostrar los resultados por consola.
            //Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.

            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);

            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);

            Console.ForegroundColor = boligrafo1.GetColor();

            boligrafo1.Pintar(10);

        }
    }
}
