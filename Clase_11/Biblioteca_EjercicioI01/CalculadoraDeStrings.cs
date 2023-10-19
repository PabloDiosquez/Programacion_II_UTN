using System;

namespace Biblioteca_EjercicioI01
{
    /// <summary>
    /// Clase que proporciona métodos para realizar operaciones matemáticas en cadenas de texto.
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
            char[] separadores = AgregarSeparador(numeros);

            string[] numerosEnLista = numeros.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            if (numerosEnLista.Length <= 1) return 0;

            if (numerosEnLista[0] == "//") numerosEnLista[0] = "0";

            int sumaAlMomento = 0;

            foreach (string numero in numerosEnLista)
            {
                if (!int.TryParse(numero, out int numeroSumado)) throw new InvalidCastException("Asegúrese de ingresar números enteros.");

                if (numeroSumado < 0) throw new NegativoNoPermitidoException("No se permiten números negativos 🥴");

                sumaAlMomento += numeroSumado;
            }
            return sumaAlMomento;
        }

        private static char[] AgregarSeparador(string numeros)
        {
            char[] separadores  = new char[] { ',', '\n'};

            if (numeros.Length >= 3)
            {
                char primerCaracter = numeros[0];

                char segundoCaracter = numeros[1];

                if (primerCaracter == '/' && segundoCaracter == '/')
                {
                    separadores = new char[] { ',', '\n', numeros[2]};
                }
            }
            return separadores;
        }
    }
    






}
