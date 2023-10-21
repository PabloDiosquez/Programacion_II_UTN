using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase que representa a un cartero, que es una persona que puede enviar mensajes.
    /// </summary>
    public class Cartero : Persona, IMensaje
    {
        private int legajo;

        /// <summary>
        /// Constructor de la clase Cartero.
        /// </summary>
        /// <param name="legajo">El número de legajo del cartero.</param>
        /// <param name="nombre">El nombre del cartero.</param>
        /// <param name="apellido">El apellido del cartero.</param>
        /// <param name="dni">El número de identificación del cartero.</param>
        public Cartero(int legajo, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Método que permite al cartero enviar un mensaje.
        /// </summary>
        /// <returns>Un mensaje indicando que se está enviando un mensaje a través del cartero.</returns>
        public string EnviarMensaje()
        {
            return "Enviando mensaje a través de un cartero...";
        }
    }
}
