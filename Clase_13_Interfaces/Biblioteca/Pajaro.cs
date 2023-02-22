using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal abstract class Pajaro
    {
        protected string tipo;

        public Pajaro(string tipo)
        {
            this.tipo = tipo;
        }

        public string Volando()
        {
            return "Volando...";
        }
    }
}
