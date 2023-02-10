using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    internal class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje) : this(mensaje, null)
        {

        }

        public MiExcepcion(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
