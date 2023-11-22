using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_02
{
    /// <summary>
    /// Proporciona funciones de ayuda y extensiones para operaciones comunes con cadenas.
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Determina si una cadena es un palíndromo (se lee igual de izquierda a derecha que de derecha a izquierda), ignorando los espacios y distinguiendo mayúsculas y minúsculas.
        /// </summary>
        /// <param name="str">La cadena a verificar.</param>
        /// <returns>true si la cadena es un palíndromo; de lo contrario, false.</returns>
        /// <exception cref="ArgumentNullException">Se produce si la cadena es nula.</exception>
        public static bool EsPalindromo(this string str)
        {
            if (str is null) throw new ArgumentNullException(nameof(str));

            return str.Replace(" ", "").ToLower() == str.Replace(" ", "").ToLower().RevertirStr();
        }

        /// <summary>
        /// Invierte una cadena utilizando un bucle for.
        /// </summary>
        /// <param name="str">La cadena a invertir.</param>
        /// <returns>La cadena invertida.</returns>
        /// <exception cref="ArgumentNullException">Se produce si la cadena es nula.</exception>
        public static string RevertirStr(this string str)
        {
            if (str is null) throw new ArgumentNullException(nameof(str));

            string invertido = string.Empty;

            for (int indice = str.Length - 1; indice >= 0; indice--)
            {
                invertido += str[indice];
            }
            return invertido;
        }

        /// <summary>
        /// Invierte una cadena de forma recursiva utilizando StringBuilder para mejorar el rendimiento.
        /// </summary>
        /// <param name="str">La cadena a invertir.</param>
        /// <returns>La cadena invertida.</returns>
        public static string RevertirStrRecursivo(this string str)
        {
            // Manejo de cadena vacía
            if (string.IsNullOrEmpty(str)) return str;

            int ultimaPosicion = str.Length - 1;

            // Utilizar StringBuilder para mejorar rendimiento
            StringBuilder reversedString = new StringBuilder();
            reversedString.Append(str[ultimaPosicion]);

            // Llamada recursiva
            reversedString.Append(RevertirStrRecursivo(str.Remove(ultimaPosicion)));

            return reversedString.ToString();
        }

        /// <summary>
        /// Cuenta el número de ocurrencias de cada vocal en una cadena.
        /// </summary>
        /// <param name="str">La cadena para contar las vocales.</param>
        /// <returns>Un array de strings con el conteo de cada vocal.</returns>
        public static string[] ContadorDeVocales(this string str)
        {
            return new string[]
            {
            $"a: {str.CantidadDeLetras("a")}",
            $"e: {str.CantidadDeLetras("e")}",
            $"i: {str.CantidadDeLetras("i")}",
            $"o: {str.CantidadDeLetras("o")}",
            $"u: {str.CantidadDeLetras("u")}"
            };
        }

        /// <summary>
        /// Cuenta el número de ocurrencias de una letra específica en una cadena de forma recursiva.
        /// </summary>
        /// <param name="str">La cadena para contar las letras.</param>
        /// <param name="letra">La letra a contar.</param>
        /// <returns>La cantidad de ocurrencias de la letra.</returns>
        public static int CantidadDeLetras(this string str, string letra)
        {
            if (string.IsNullOrEmpty(str)) return 0;

            return UnoSiCeroSino(str[0].ToString() == letra) + CantidadDeLetras(str.Substring(1), letra);
        }

        /// <summary>
        /// Retorna 1 si la condición es verdadera, de lo contrario, retorna 0.
        /// </summary>
        /// <param name="condicion">La condición a evaluar.</param>
        /// <returns>1 si la condición es verdadera; de lo contrario, 0.</returns>
        public static int UnoSiCeroSino(bool condicion)
        {
            return condicion ? 1 : 0;
        }
    }
}
