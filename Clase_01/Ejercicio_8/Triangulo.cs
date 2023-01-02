using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal static class Triangulo
    {
        public static void estrellas(int cuantas)
        {
            for (int i = 0; i < cuantas; i++)
            {
                Console.Write("*");
            }
        }

        public static void crearTriangulo(int altura)
        {
            for (int i = 1; i <= altura; i++)
            {
                estrellas(2 * i - 1);

                Console.WriteLine();
            }
        }
    }
}
