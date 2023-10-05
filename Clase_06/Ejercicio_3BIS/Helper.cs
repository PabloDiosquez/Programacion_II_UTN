using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3BIS
{
    public static class Helper
    {
        /// <summary>
        /// Cuenta la frecuencia de cada palabra en un texto dado.
        /// </summary>
        /// <param name="texto">El texto en el que contar las palabras.</param>
        /// <returns>Un diccionario que mapea cada palabra única con su frecuencia.</returns>
        public static Dictionary<string, int> ContadorDePalabras(string texto)
        {
            // Crear un diccionario para almacenar las palabras y sus frecuencias.
            Dictionary<string, int> contador = new Dictionary<string, int>();

            // Separar el texto en palabras usando un espacio como delimitador.
            char[] delimitadores = new char[] { ' ', '\n' };

            // Dividir el texto en palabras y contar su frecuencia.
            foreach (string palabra in texto.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries))
            {
                // Si la palabra ya está en el diccionario, aumentar su frecuencia.
                if (contador.ContainsKey(palabra))
                {
                    contador[palabra]++;
                }
                else
                {
                    // Si la palabra no está en el diccionario, agregarla con una frecuencia inicial de 1.
                    contador[palabra] = 1;
                }
            }

            // Devolver el diccionario con las palabras y sus frecuencias.
            return contador;
        }

        /// <summary>
        /// Genera una representación de cadena que muestra los datos contenidos en un diccionario.
        /// </summary>
        /// <param name="diccionario">El diccionario que se va a mostrar.</param>
        /// <returns>Una cadena que muestra las claves y valores del diccionario.</returns>
        public static string MostrarDatos(Dictionary<string, int> diccionario)
        {
            // Crear un StringBuilder para construir la representación de cadena.
            StringBuilder sb = new StringBuilder();

            // Recorrer el diccionario y agregar cada clave y valor al StringBuilder.
            foreach (KeyValuePair<string, int> par in diccionario)
            {
                // Agregar la clave y el valor al StringBuilder en el formato "clave: valor".
                sb.Append($"{par.Key}: {par.Value}\n");
            }
            // Devolver la representación de cadena generada.
            return sb.ToString();
        }
    }
}
