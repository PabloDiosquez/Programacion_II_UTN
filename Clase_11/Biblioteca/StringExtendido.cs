using System;

namespace Biblioteca
{
    public static class StringExtendido
    {
        /// <summary>
        /// Cuenta el número de palabras en una cadena de texto.
        /// </summary>
        /// <param name="str">La cadena de texto en la que contar palabras.</param>
        /// <returns>El número de palabras en la cadena de texto.</returns>
        /// <exception cref="ArgumentException">Se lanza cuando la cadena de texto es nula o vacía.</exception>
        public static int ContarPalabras(this string str)
        {
            char[] separadores = new char[] { ' ', '-', '.' };

            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("La cadena de texto no puede ser ni vacía ni nula");
            }
            return str.Split(separadores, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /// <summary>
        /// Cuenta el número de apariciones de una palabra en una cadena de texto.
        /// </summary>
        /// <param name="str">La cadena de texto en la que buscar la palabra.</param>
        /// <param name="palabraBuscada">La palabra que se busca contar en la cadena de texto.</param>
        /// <returns>El número de apariciones de la palabra en la cadena de texto.</returns>
        /// <exception cref="ArgumentException">Se lanza cuando la cadena de texto es nula o vacía.</exception>
        public static int ContarApariciones(this string str, string palabraBuscada)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("La cadena de texto no puede ser ni vacía ni nula");
            }

            char[] separadores = new char[] { ' ', '-', ',', '.'};
            int cantidadDeAparicionesAlMomento = 0;

            foreach (string palabra in str.Split(separadores, StringSplitOptions.RemoveEmptyEntries))
            {
                if (palabraBuscada.ToLower() == palabra.ToLower())
                {
                    cantidadDeAparicionesAlMomento++;
                }
            }
            return cantidadDeAparicionesAlMomento;
        }
    }
}
