using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            char[] letras = new char[5];

            Console.WriteLine("### Carga del array ###");
            Array.cargaArray(letras);

            Console.WriteLine("### Lectura del array ###");
            Array.lecturaArray(letras);
            
        }

    }
}
