using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Paloma : Pajaro, IMensaje
    {
        private int id;

        private string destino;

        public Paloma(int id, string destino) : base("Paloma")
        {
            this.id = id;

            this.destino = destino;
        }

        public string EnviarMensaje()
        {
            return "Enviando mensaje";
        }
    }
}
