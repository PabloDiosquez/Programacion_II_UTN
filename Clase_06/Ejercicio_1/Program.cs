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

            Random random = new Random();

            int[] numeros = new int[20];

            // Carga del vector
            for (int i = 0; i < 20; i++) 
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

            foreach (int numero in numeros) 
            {
                Console.WriteLine(numero);
            }
            
            // b) 

            List<int> positivos = new List<int>();

            foreach (int numero in numeros) 
            {
                if (numero > 0) 
                {
                    positivos.Add(numero);
                }
            }

            Console.WriteLine();

            // Ordenar la lista de forma decreciente

            positivos.Sort(Comparacion);

            Console.WriteLine("Lista de números positivos ordenada de forma decreciente:");

            foreach (int numero in positivos) 
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();

            List<int> negativos = new List<int>();

            foreach (int numero in numeros)
            {
                if (numero < 0) 
                {
                    negativos.Add(numero);
                }
            }

            Console.WriteLine("Lista de números negativos ordenada de forma creciente: ");

            negativos.Sort();

            foreach (int numero in negativos)
            {
                Console.WriteLine(numero);
            }

        }

        public static int Comparacion(int num1, int num2) 
        {
            return num2 - num1;
        }
    }
}
