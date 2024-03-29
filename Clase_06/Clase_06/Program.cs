﻿using System;
using System.Collections.Generic;

namespace Clase_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            int[] numeros1 = { 1, 2, 3, 4, 5, 6, 7, };

            int[] numeros = new int[5];

            // Cargar el Array

            numeros[0] = -1;

            numeros[1] = 2;

            numeros[2] = -21;

            numeros[3] = 0;

            numeros[4] = 3;

            // Recorrer el Array

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            // forEach

            //foreach  (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            #endregion


            #region Listas

            List<string> nombres = new List<string>();

            nombres.Add("Lio");
            nombres.Add("Emiliano");
            nombres.Add("Enzo");

            // ¿Cómo recorremos la colección? 👉🏼 forEach

            Console.WriteLine("### Recorriendo la colección ###");
            foreach (string nombre in nombres)
            {
                Console.WriteLine($"Nombre: {nombre}");
            }

            //nombres.Remove("Emiliano");
            nombres.RemoveAt(1); // 👉🏼 índice

            Console.WriteLine(nombres[1]);

            Console.WriteLine($"Cantidad de elementos: {nombres.Count}");

            List<int> numeros2 = new List<int>();

            numeros2.Add(1);
            numeros2.Add(12);
            numeros2.Add(-1);
            numeros2.Add(0);
            numeros2.Add(-16);
            numeros2.Add(32);

            numeros2.Sort(); // Ordena la lista de menor a mayor 

            //foreach (int numero in numeros2)
            //{
            //    Console.WriteLine(numero);
            //}

            numeros2.Sort(Comparacion); // Ordena la lista de mayor a menor (a Sort se le pasa una referencia al método Comparacion 👌🏼)

            Console.WriteLine();

            //foreach (int numero in numeros2) 
            //{
            //    Console.WriteLine(numero);
            //}

            #endregion

            #region Diccionarios

            //Dictionary<int, string> dicc = new Dictionary<int, string>();

            //dicc.Add(10, "Lio Messi");
            //dicc.Add(1, "Emiliano Martínez");
            //dicc.Add(5,"Enzo Fernández");

            //// Recorrer el diccionario

            //foreach (KeyValuePair<int, string> item in dicc)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine($"Clave: {item.Key} >>> Valor: {item.Value}");
            //    Console.WriteLine();
            //}

            //// Se pueden recorrer sólo los valores o las claves...

            //foreach (int clave in dicc.Keys)
            //{
            //    Console.WriteLine($"Clave: {clave}");
            //}

            //Console.WriteLine();

            //foreach  (string valor in dicc.Values)
            //{
            //    Console.WriteLine($"Valor: {valor}");
            //}

            //Console.WriteLine();

            //if (dicc.ContainsKey(10))
            //{
            //    Console.WriteLine($"{dicc[10]} está agendado");
            //}
            //else
            //{
            //    Console.WriteLine("Deberías agendar al mejor jugador del mundo!");
            //}

            //Console.WriteLine();

            //if(dicc.TryGetValue(10, out string jugador))
            //{
            //    Console.WriteLine(jugador);
            //}

            #endregion

            #region Queue // FIFO >>> First In First Out

            // Queue >>> No están indexadas y no se pueden ordenar ⚠

            //Queue<string> colaStrings = new Queue<string>();

            //colaStrings.Enqueue("Lionel");
            //colaStrings.Enqueue("Julián");
            //colaStrings.Enqueue("Lautaro");

            //foreach (string nombre in colaStrings)
            //{
            //    Console.WriteLine(nombre);
            //}

            //string primerEliminado = colaStrings.Dequeue(); // Elimina el elemento ubicado al principio de la cola y lo retorna.

            //Console.WriteLine();

            //foreach (string nombre in colaStrings) 
            //{
            //    Console.WriteLine(nombre);
            //}

            //Console.WriteLine();

            //string primerElem = colaStrings.Peek(); // Peek() >>> nos devuelve el primer elemento de la cola sin eliminarlo.

            //Console.WriteLine($"Primer elemento: {primerElem}");

            #endregion

            #region Pilas // LIFO >>> Last In First Out

            Stack<string> pilaStrings = new Stack<string>();

            pilaStrings.Push("Lio");
            pilaStrings.Push("Julián");
            pilaStrings.Push("Enzo");

            foreach (string nombre in pilaStrings)
            {
                Console.WriteLine(nombre);
            }

            //string primerElem = pilaStrings.Peek(); // Peek() >>> nos devuelve el último elemento de la pila sin eliminarlo.

            string topeString = pilaStrings.Peek();

            Console.WriteLine($"Tope de la pila >>> {topeString}");

            Console.WriteLine();

            string ultimoNombre = pilaStrings.Pop(); // Eimina de la lista el último objeto que entró y lo retorna.

            foreach (string nombre in pilaStrings)
            {
                Console.WriteLine(nombre);
            }

            if (pilaStrings.Contains("Julián")) // >>> Contains() compara por el tipo de comparación que tenga dentro.
                                                // Ej: Los tipos referencia compara si apuntan a la misma dirección de memoria
                                                // los de tipo valor por su valor, etc⚠
            {
                Console.WriteLine("Está en la lista!");
            }

            #endregion

        }

        public static int Comparacion(int a, int b) 
        {
            return b - a;
        }
    }
}
