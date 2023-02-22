using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Cartero : Persona, IMensaje
    {
        private int legajo;
        public Cartero(int legajo, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {

        }

        public string EnviarMensaje()
        {
            return "Enviando mensaje a través de un cartero...";
        }
    }
}
