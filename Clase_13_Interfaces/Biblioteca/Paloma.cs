using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase que representa a una paloma mensajera que puede enviar mensajes.
    /// </summary>
    public class Paloma : Pajaro, IMensaje
    {
        private int id;
        private string destino;

        /// <summary>
        /// Constructor de la clase Paloma.
        /// </summary>
        /// <param name="id">El identificador único de la paloma mensajera.</param>
        /// <param name="destino">El destino del mensaje.</param>
        public Paloma(int id, string destino) : base("Paloma")
        {
            this.id = id;
            this.destino = destino;
        }

        /// <summary>
        /// Método que permite a la paloma mensajera enviar un mensaje.
        /// </summary>
        /// <returns>Un mensaje indicando que se está enviando un mensaje a través de una paloma mensajera.</returns>
        public string EnviarMensaje()
        {
            return "Enviando mensaje a través de una paloma mensajera...";
        }
    }
}
