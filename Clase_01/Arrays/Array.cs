using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal static class Array
    {
        public static void cargaArray(char[] letras)
        {
            for (int i = 0; i < letras.Length; i++)
            {
                Console.WriteLine($"letras[{i}]:");
                while (!char.TryParse(Console.ReadLine(), out letras[i]))
                    Console.WriteLine("Ingrese un caracter:");
            }

        }
        public static void lecturaArray(char[] letras)
        {
            for (int i = 0; i < letras.Length; i++)
                Console.WriteLine($"letras[{i}]: {letras[i]}");
        }
    }
}
