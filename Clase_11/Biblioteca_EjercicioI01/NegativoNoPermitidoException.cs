using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_EjercicioI01
{
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException(string mensaje, Exception inner) : base(mensaje, inner){}

        public NegativoNoPermitidoException(string mensaje) : this(mensaje, null) { }
    }
}
