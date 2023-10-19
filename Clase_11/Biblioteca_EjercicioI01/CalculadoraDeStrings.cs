using System;

namespace Biblioteca_EjercicioI01
{
    /// <summary>
    /// Esta clase proporciona métodos para realizar cálculos con cadenas de números.
    /// </summary>
    public static class CalculadoraDeStrings
    {
        /// <summary>
        /// Suma los números contenidos en una cadena de texto que puede contener hasta dos números separados por comas o saltos de línea.
        /// </summary>
        /// <param name="numeros">La cadena de texto que contiene los números a sumar.</param>
        /// <returns>La suma de los números contenidos en la cadena de texto.</returns>
        /// <exception cref="Exception">Se lanza si se encuentra un valor no válido o no entero en la cadena.</exception>
        public static int Add(this string numeros)
        {
            // Obtener los separadores a partir de la cadena de entrada.
            char[] separadores = AgregarSeparador(numeros);

            // Dividir la cadena en números.
            string[] numerosEnLista = numeros.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            // Si no hay números, devolver 0.
            if (numerosEnLista.Length <= 1) return 0;

            // Si el primer elemento es "//", reemplazarlo con "0".
            if (numerosEnLista[0] == "//") numerosEnLista[0] = "0";

            int sumaAlMomento = 0;

            foreach (string numero in numerosEnLista)
            {
                // Intentar convertir el número a entero.
                if (!int.TryParse(numero, out int numeroSumado))
                    throw new InvalidCastException("Asegúrese de ingresar números enteros.");

                // Si el número es negativo, lanzar una excepción personalizada.
                if (numeroSumado < 0)
                    throw new NegativoNoPermitidoException("No se permiten números negativos 🥴");

                // Sumar el número al resultado.
                sumaAlMomento += numeroSumado;
            }
            return sumaAlMomento;
        }

        /// <summary>
        /// Obtiene los separadores a partir de la cadena de entrada.
        /// </summary>
        /// <param name="numeros">La cadena de texto que contiene los números y, opcionalmente, el separador personalizado.</param>
        /// <returns>Un arreglo de caracteres que contiene los separadores a utilizar para dividir la cadena.</returns>
        private static char[] AgregarSeparador(string numeros)
        {
            char[] separadores = new char[] { ',', '\n' };

            if (numeros.Length >= 3)
            {
                char primerCaracter = numeros[0];
                char segundoCaracter = numeros[1];

                // Si los primeros caracteres son "//", el tercer carácter es el separador personalizado.
                if (primerCaracter == '/' && segundoCaracter == '/')
                {
                    separadores = new char[] { ',', '\n', numeros[2] };
                }
            }
            return separadores;
        }
    }
}
