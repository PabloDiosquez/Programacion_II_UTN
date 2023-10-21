using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Interfaz para enviar mensajes.
    /// </summary>
    public interface IMensaje
    {
        /// <summary>
        /// Método que permite enviar un mensaje.
        /// </summary>
        /// <returns>El mensaje enviado como una cadena de caracteres.</returns>
        string EnviarMensaje();
    }
}
