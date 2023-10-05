using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    // Clase formada por funciones auxiliares.
    public static class Helper
    {
        /// <summary>
        /// Carga números enteros aleatorios en un array.
        /// </summary>
        /// <param name="numeros">Array de números enteros</param>
        /// <param name="cantidad">Cantidad de elementos del array</param>
        public static void CargaEnterosEnArray(int[] numeros)
        {
            Random rd = new Random();
            int index = 0;
            int randInt;

            while (index < numeros.Length)
            {
                randInt = rd.Next(-100, 101); // El rango de números aleatorios (-100 a 100).

                if (randInt != 0)
                {
                    numeros[index] = randInt;
                    index++;
                }
            }
        }

        /// <summary>
        /// Muestra los números enteros contenidos en un array en la consola.
        /// </summary>
        /// <param name="numeros">El array de números enteros que se va a mostrar.</param>
        public static void MostrarEnterosEnArray(int[] numeros)
        {
            // Recorre cada elemento del array y lo muestra en la consola.
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        /// <summary>
        /// Ordena un array de enteros de menor a mayor utilizando el algoritmo de selección.
        /// </summary>
        /// <param name="numeros">El array de enteros que se va a ordenar.</param>
        public static void OrdenarArrayDeMenorAMayor(int[] numeros)
        {
            int indiceDelMinimo;

            for (int i = 0; i < numeros.Length; i++)
            {
                indiceDelMinimo = ObtenerElIndiceDelMinimoEnElArrayDesde(numeros, i);

                Intercambiar(numeros, i, indiceDelMinimo);
            }
        }

        /// <summary>
        /// Encuentra y devuelve el índice del valor mínimo en un array de enteros, comenzando desde una posición específica.
        /// </summary>
        /// <param name="numeros">El array de enteros en el que se buscará el mínimo.</param>
        /// <param name="desde">El índice a partir del cual se iniciará la búsqueda del mínimo.</param>
        /// <returns>El índice del valor mínimo encontrado en el array.</returns>
        private static int ObtenerElIndiceDelMinimoEnElArrayDesde(int[] numeros, int desde)
        {
            int indiceDelMinimo = desde;

            for (int index = desde + 1; index < numeros.Length; index++)
            {
                if (numeros[index] < numeros[indiceDelMinimo])
                {
                    indiceDelMinimo = index;
                }
            }

            return indiceDelMinimo;
        }

        /// <summary>
        /// Encuentra y devuelve el valor mínimo en un array de enteros.
        /// </summary>
        /// <param name="numeros">El array de enteros en el que se buscará el mínimo.</param>
        /// <returns>El valor mínimo encontrado en el array.</returns>
        private static int ObtenerElMinimoDelArray(int[] numeros)
        {
            int minimoAlMomento = numeros[0];

            foreach (int numero in numeros)
            {
                minimoAlMomento = minimoEntre(numero, minimoAlMomento);
            }

            return minimoAlMomento;
        }

        /// <summary>
        /// Describe el número más chico entre los dos números dados.
        /// </summary>
        /// <param name="numero1">El primer número a comparar</param>
        /// <param name="numero2">El segundo número a comparar</param>
        /// <returns>El menor entre los dos números dados</returns>
        private static int minimoEntre(int numero1, int numero2)
        {
            if (numero1 < numero2) return numero1;

            return numero2;
        }

        /// <summary>
        /// Intercambia dos elementos en un array.
        /// </summary>
        /// <param name="array">El array en el que se realizará el intercambio.</param>
        /// <param name="indiceA">El índice del primer elemento a intercambiar.</param>
        /// <param name="indiceB">El índice del segundo elemento a intercambiar.</param>
        private static void Intercambiar(int[] array, int indiceA, int indiceB)
        {
            int auxiliar = array[indiceA];
            array[indiceA] = array[indiceB];
            array[indiceB] = auxiliar;
        }
    }
}
