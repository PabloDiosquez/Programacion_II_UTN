using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesAuxliares
{
    /// <summary>
    /// Clase que proporciona métodos para la conversión entre el sistema decimal y binario.
    /// </summary>
    public static class ConversorBinario
    {
        /// <summary>
        /// Convierte un número entero del sistema decimal al sistema binario.
        /// </summary>
        /// <param name="numeroEntero">Número entero a convertir</param>
        /// <returns>Una cadena de caracteres que representa la representación binaria del número dado (string)</returns>
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            // Implementa la lógica para convertir el número decimal al sistema binario y devuelve el resultado como una cadena.

            string binario = string.Empty;

            int resto;

            while (numeroEntero > 0)
            {
                resto = numeroEntero % 2;

                binario = resto + binario;

                numeroEntero = numeroEntero / 2;
            }

            return binario;
        }

        /// <summary>
        /// Convierte una cadena que representa un número binario en un número entero decimal.
        /// </summary>
        /// <param name="numeroBinario">Cadena que representa un número binario a convertir</param>
        /// <returns>Un número entero decimal equivalente al número binario dado</returns>
        /// <exception cref="ArgumentException">Se lanza si la cadena contiene caracteres que no son '0' o '1'</exception>
        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            // Verifica que la cadena contenga solo caracteres '0' o '1'
            if (!EsBinarioValido(numeroBinario))
            {
                throw new ArgumentException("La cadena contiene caracteres que no son '0' o '1'.", nameof(numeroBinario));
            }

            int numeroEnDecimal = 0;

            for (int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                int digito = numeroBinario[i] - '0'; // Convierte el carácter '0' o '1' en su valor numérico correspondiente.

                numeroEnDecimal += digito * (int)Math.Pow(2, numeroBinario.Length - 1 - i);
            }

            return numeroEnDecimal;
        }

        /// <summary>
        /// Verifica si una cadena contiene solo caracteres '0' o '1'.
        /// </summary>
        /// <param name="cadena">Cadena a verificar</param>
        /// <returns>true si la cadena contiene solo '0' o '1', false en caso contrario</returns>
        public static bool EsBinarioValido(string cadenaAValidar)
        {
            char[] ceroYUno = new char[] { '0', '1' };

            foreach (char caracter in cadenaAValidar)
            {
                if (!ceroYUno.Contains(caracter)) return false;
            }

            return true;
        }
    }
}
