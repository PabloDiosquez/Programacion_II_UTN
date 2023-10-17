using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    /// <summary>
    /// Excepción personalizada lanzada cuando uno o más parámetros están vacíos o nulos.
    /// </summary>
    public class ParametrosVaciosException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase ParametrosVaciosException con un mensaje de error.
        /// </summary>
        /// <param name="mensaje">Mensaje de error que describe la razón de la excepción.</param>
        public ParametrosVaciosException(string mensaje) : this(mensaje, null) { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase ParametrosVaciosException con un mensaje de error y una excepción interna.
        /// </summary>
        /// <param name="mensaje">Mensaje de error que describe la razón de la excepción.</param>
        /// <param name="inner">Excepción interna que desencadenó esta excepción (puede ser nula).</param>
        public ParametrosVaciosException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
