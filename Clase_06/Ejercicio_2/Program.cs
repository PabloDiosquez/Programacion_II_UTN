using System;
using System.Collections.Generic;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos)
            // distintos de cero de forma aleatoria utilizando la clase Random.

            // Mostrar la colección tal como fue cargada.
            // Luego mostrar los positivos ordenados en forma decreciente.
            //  Por último, mostrar los negativos ordenados en forma creciente.

            Random random = new Random();

            List<int> numeros = new List<int>();

            Stack<int> pilaNeg = new Stack<int>();

            Queue<int> colaPos = new Queue<int>();

            int CANTIDAD = 20;

            // Cargar la lista 

            for (int i = 0; i < CANTIDAD; i++) 
            {
                int randInt = random.Next(-100,101);

                if (randInt != 0)
                {
                    numeros.Add(randInt);
                }
                else 
                {
                    i--;
                }
            }

            Console.WriteLine("Lista original:");

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine($"{i+1}: {numeros[i]}");
            }

            // Mostrar los números positivos de forma decreciente.

            numeros.Sort(OrdenDescendente);

            Console.WriteLine("Números positivos ordenados de forma decreciente:");

            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine($"{i + 1}: {numeros[i]}");

                    colaPos.Enqueue(numeros[i]);
                }

                else 
                {
                    pilaNeg.Push(numeros[i]);   
                }
            }

            Console.WriteLine("Números negativos ordenados de forma creciente:");

            foreach (int numero in pilaNeg)
            {
                Console.WriteLine(numero);
            }

        }

        public static int OrdenDescendente(int a, int b) 
        {
            return b - a;
        }
    }
}
