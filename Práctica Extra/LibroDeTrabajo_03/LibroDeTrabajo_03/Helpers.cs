using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_03
{
    /// <summary>
    /// Clase estática de ayuda con métodos para manipular cadenas.
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Verifica si una cadena es un palíndromo.
        /// </summary>
        /// <param name="str">La cadena a verificar.</param>
        /// <returns>True si la cadena es un palíndromo, False si no lo es.</returns>
        public static bool EsPalindromo(this string str)
        {
            // Utiliza los métodos de extensión para remover espacios en blanco e invertir el texto
            return str.RemoverEspaciosEnBlanco() == str.InvertirTexto();
        }

        /// <summary>
        /// Invierte el orden de los caracteres en una cadena.
        /// </summary>
        /// <param name="str">La cadena a invertir.</param>
        /// <returns>La cadena invertida.</returns>
        private static string InvertirTexto(this string str)
        {
            // Utiliza el método de extensión para remover espacios en blanco y luego invierte los caracteres
            return str.RemoverEspaciosEnBlanco().InvertirCaracteres();
        }

        /// <summary>
        /// Remueve los espacios en blanco de una cadena.
        /// </summary>
        /// <param name="str">La cadena a procesar.</param>
        /// <returns>La cadena sin espacios en blanco.</returns>
        private static string RemoverEspaciosEnBlanco(this string str)
        {
            // Utiliza el método Split para dividir la cadena por espacios en blanco y luego junta los resultados
            return string.Join(string.Empty, str.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }

        /// <summary>
        /// Invierte el orden de los caracteres en una cadena.
        /// </summary>
        /// <param name="str">La cadena a invertir.</param>
        /// <returns>La cadena invertida.</returns>
        private static string InvertirCaracteres(this string str)
        {
            // Verifica si la cadena es nula y lanza una excepción si es así
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            // Invierte los caracteres en la cadena
            string strInvertido = string.Empty;

            foreach (char caracter in str)
            {
                strInvertido = caracter + strInvertido;
            }
            return strInvertido;
        }
    }
}
