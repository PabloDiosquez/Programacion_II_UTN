using System;

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

            foreach  (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            #endregion
        }
    }
}
