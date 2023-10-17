using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01_Program
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje) : base(mensaje) { }
    }
}
