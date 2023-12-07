using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_07
{
    public class ValorNoEncontradoException : Exception
    {
        public ValorNoEncontradoException(string mensaje) : base(mensaje)
        {
        }
    }
}
