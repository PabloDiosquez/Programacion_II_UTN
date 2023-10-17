using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    // <summary>
    /// Excepción personalizada lanzada cuando se ingresan números negativos en los campos de entrada.
    /// </summary>
    public class NumerosNegativosException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase NumerosNegativosException con un mensaje de error y una excepción interna.
        /// </summary>
        /// <param name="mensaje">Mensaje de error que describe la razón de la excepción.</param>
        /// <param name="inner">Excepción interna que desencadenó esta excepción (puede ser nula).</param>
        public NumerosNegativosException(string mensaje, Exception inner) : base(mensaje, inner) { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase NumerosNegativosException con un mensaje de error.
        /// </summary>
        /// <param name="mensaje">Mensaje de error que describe la razón de la excepción.</param>
        public NumerosNegativosException(string mensaje) : this(mensaje, null) { }
    }
}
