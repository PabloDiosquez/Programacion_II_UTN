using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class Helpers
    {
        /// <summary>
        /// Cuenta la cantidad total de letras en un texto.
        /// </summary>
        /// <param name="texto">El texto del cual contar las letras.</param>
        /// <returns>La cantidad total de letras en el texto.</returns>
        public static int ContarLetras(string texto)
        {
            int cantidadLetrasAlMomento = 0;

            foreach (string palabra in texto.Split(' ', options: StringSplitOptions.RemoveEmptyEntries))
            {
                cantidadLetrasAlMomento += palabra.Length;
            }
            return cantidadLetrasAlMomento;
        }

        /// <summary>
        /// Valida y obtiene un número entero ingresado por el usuario.
        /// </summary>
        /// <returns>El número entero validado.</returns>
        public static int ValidarNumeroEntero()
        {
            int numero;

            Console.WriteLine("Ingrese un número entero:");

            while (!int.TryParse(Console.ReadLine(), out numero)) Console.WriteLine("Asegúrese de ingresar un número entero...");

            return numero;
        }

        /// <summary>
        /// Valida y obtiene un número real ingresado por el usuario.
        /// </summary>
        /// <returns>El número real validado.</returns>
        public static double ValidarNumero()
        {
            double numero;

            Console.WriteLine("Ingrese un número real:");

            while (!double.TryParse(Console.ReadLine(), out numero)) Console.WriteLine("Asegúrese de ingresar un número...");

            return numero;
        }

        /// <summary>
        /// Calcula el promedio de un arreglo de números enteros.
        /// </summary>
        /// <param name="numeros">Arreglo de números enteros.</param>
        /// <returns>El promedio de los números enteros.</returns>
        public static double CalcularPromedio(int[] numeros)
        {
            double total = 0;

            foreach (int numero in numeros)
            {
                total += numero;
            }
            return total / numeros.Length;
        }

        /// <summary>
        /// Encuentra el valor máximo en un arreglo de números enteros.
        /// </summary>
        /// <param name="numeros">Arreglo de números enteros.</param>
        /// <returns>El valor máximo en el arreglo.</returns>
        public static int Maximo(int[] numeros)
        {
            int maximoAlMomento = numeros[0];

            foreach (int numero in numeros)
            {
                maximoAlMomento = MaximoEntre(maximoAlMomento, numero);
            }
            return maximoAlMomento;
        }

        /// <summary>
        /// Encuentra el valor mínimo en un arreglo de números enteros.
        /// </summary>
        /// <param name="numeros">Arreglo de números enteros.</param>
        /// <returns>El valor mínimo en el arreglo.</returns>
        public static int Minimo(int[] numeros)
        {
            int minimoAlMomento = numeros[0];

            foreach (int numero in numeros)
            {
                minimoAlMomento = MinimoEntre(minimoAlMomento, numero);
            }
            return minimoAlMomento;
        }

        /// <summary>
        /// Determina el máximo entre dos números enteros.
        /// </summary>
        /// <param name="primerNumero">Primer número entero.</param>
        /// <param name="segundoNumero">Segundo número entero.</param>
        /// <returns>El valor máximo entre los dos números.</returns>
        public static int MaximoEntre(int primerNumero, int segundoNumero)
        {
            if (primerNumero >= segundoNumero) return primerNumero;

            return segundoNumero;
        }

        /// <summary>
        /// Determina el mínimo entre dos números enteros.
        /// </summary>
        /// <param name="primerNumero">Primer número entero.</param>
        /// <param name="segundoNumero">Segundo número entero.</param>
        /// <returns>El valor mínimo entre los dos números.</returns>
        public static int MinimoEntre(int primerNumero, int segundoNumero)
        {
            if (primerNumero <= segundoNumero) return primerNumero;

            return segundoNumero;
        }

        /// <summary>
        /// Verifica si un número es múltiplo de otro.
        /// </summary>
        /// <param name="numero">El número a verificar.</param>
        /// <param name="divisor">El divisor para verificar si el número es múltiplo.</param>
        /// <returns>True si el número es múltiplo del divisor, False en caso contrario.</returns>
        public static bool esMultiploDe(int numero, int divisor)
        {
            return numero % divisor == 0;
        }

        /// <summary>
        /// Verifica si un número es par.
        /// </summary>
        /// <param name="numero">El número a verificar.</param>
        /// <returns>True si el número es par, False en caso contrario.</returns>
        public static bool esPar(int numero)
        {
            return esMultiploDe(numero, 2);
        }
    }
}
