using System;
using System.Collections.Generic;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma
            // aleatoria utilizando la clase Random.

            // a) Mostrar el vector tal como fue ingresado.
            // b) Luego mostrar los positivos ordenados en forma decreciente.
            // Por último, mostrar los negativos ordenados en forma creciente.

            int[] numeros = new int[20];
            Random random = new Random();

            // Carga del vector
            for (int i = 0; i < numeros.Length; i++) 
            {
                int randInt = random.Next(-100, 101);

                if (randInt != 0)
                {
                    numeros[i] = randInt;
                }
                else 
                {
                    i--;
                }
            }

            // a)

            Console.WriteLine("Array original");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{i+1}: {numeros[i]}");
            }

            // b) 

            Console.WriteLine("Números positivos ordenados en forma decreciente:");

            // Ordenar la lista de forma decreciente

            Array.Sort(numeros,Comparacion);

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] >  0) 
                {
                    Console.WriteLine($"{i+1}: {numeros[i]}");
                }
            }

            Console.WriteLine();

            // c)
            // 

            Console.WriteLine("Números negativos ordenados de forma creciente: ");

            Array.Sort(numeros);

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0) 
                {
                    Console.WriteLine($"{i + 1}: {numeros[i]}");
                }
            }

        }
        private static int Comparacion(int num1, int num2) 
        {
            return num2 - num1;
        }
    }
}
