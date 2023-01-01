using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

            // El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            // Escribir una aplicación que encuentre los 4 primeros números perfectos.

            int i = 6, total = 0;
            
            Console.WriteLine("Primeros 4 números perfectos:\n");


            while (total < 4)
            {
                if (Divisores.esNumeroPerfecto(i)) 
                {
                    Console.WriteLine(i);
                    total++;
                }

                i++;
            }
        }

    }
}
