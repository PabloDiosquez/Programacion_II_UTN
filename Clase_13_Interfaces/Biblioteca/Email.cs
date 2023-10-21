using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase que representa un mensaje de correo electrónico.
    /// </summary>
    public class Email : IMensaje
    {
        private string origen;
        private string destino;

        /// <summary>
        /// Constructor de la clase Email.
        /// </summary>
        /// <param name="origen">La dirección de correo electrónico de origen.</param>
        /// <param name="destino">La dirección de correo electrónico de destino.</param>
        public Email(string origen, string destino)
        {
            this.origen = origen;
            this.destino = destino;
        }

        /// <summary>
        /// Método que permite enviar un mensaje a través de un correo electrónico.
        /// </summary>
        /// <returns>Un mensaje indicando que se está enviando un mensaje a través de un email.</returns>
        public string EnviarMensaje()
        {
            return "Enviando el mensaje a través de un email...";
        }
    }
}
