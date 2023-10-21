using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase base abstracta que representa a un pájaro.
    /// </summary>
    public abstract class Pajaro
    {
        protected string tipo;

        /// <summary>
        /// Constructor de la clase Pajaro.
        /// </summary>
        /// <param name="tipo">El tipo de pájaro.</param>
        public Pajaro(string tipo)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Método que representa la acción de volar.
        /// </summary>
        /// <returns>Un mensaje indicando que el pájaro está volando.</returns>
        public string Volando()
        {
            return "Volando...";
        }
    }
}
