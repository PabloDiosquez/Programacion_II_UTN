using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Email : IMensaje
    {
        private string origen;

        private string destino;

        public Email(string origen, string destino)
        {
            this.origen = origen;

            this.destino = destino;
        }

        public string EnviarMensaje()
        {
            return "Enviando el mensaje a través de un email...";
        }
    }
}
