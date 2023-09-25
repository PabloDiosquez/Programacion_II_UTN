using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sumador
{
    /// <summary>
    /// Representa un sumador que realiza operaciones de suma y realiza un seguimiento de la cantidad de sumas realizadas.
    /// </summary>
    internal class Sumador
    {
        // Atributos 
        private int cantidadSumas;

        /// <summary>
        /// Inicializa una nueva instancia de la clase Sumador con una cantidad inicial de sumas.
        /// </summary>
        /// <param name="cantidadSumas">Cantidad inicial de sumas</param>
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Sumador con una cantidad inicial de sumas igual a cero.
        /// </summary>
        public Sumador() : this(0) { }

        /// <summary>
        /// Realiza una suma de dos números enteros y aumenta la cantidad de sumas realizadas.
        /// </summary>
        /// <param name="sumando1">Primer número a sumar</param>
        /// <param name="sumando2">Segundo número a sumar</param>
        /// <returns>La suma de los números dados por parámetros (long)</returns>
        public long Sumar(long sumando1, long sumando2)
        {
            cantidadSumas++;
            return sumando1 + sumando2;
        }

        /// <summary>
        /// Realiza una concatenación de dos cadenas de caracteres y aumenta la cantidad de sumas realizadas.
        /// </summary>
        /// <param name="sumando1">Primer cadena a sumar</param>
        /// <param name="sumando2">Segunda cadena a sumar</param>
        /// <returns>Cadena de caracteres que resulta de concatenar las dos dadas (string)</returns>
        public string Sumar(string sumando1, string sumando2)
        {
            cantidadSumas++;
            return sumando1 + sumando2;
        }

        /// <summary>
        /// Obtiene una representación en forma de cadena que describe la cantidad de sumas realizadas por el sumador.
        /// </summary>
        /// <returns>Una cadena de caracteres que describe la cantidad de sumas realizadas por el sumador.</returns>
        public override string ToString()
        {
            return $"Cantidad de sumas: {cantidadSumas}";
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Realiza la suma de los valores del atributo 'cantidadSumas' de dos sumadores dados.
        /// </summary>
        /// <param name="sumador1">Primer sumador</param>
        /// <param name="sumador2">Segundo sumador</param>
        /// <returns>La suma de las cantidades de sumas de los sumadores (long)</returns>
        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }

        /// <summary>
        /// Comprueba si los dos sumadores dados tienen el mismo valor en el atributo 'cantidadSumas'.
        /// </summary>
        /// <param name="sumador1">Uno de los sumadores a comparar</param>
        /// <param name="sumador2">Otro sumador a comparar</param>
        /// <returns>true si los sumadores tienen la misma cantidad de sumas, de lo contrario, false (bool)</returns>
        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }
    }
}
