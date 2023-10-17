using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01_Program
{
    public class UnaExcepcion : Exception
    {

        public UnaExcepcion(string mensaje) : base(mensaje) { }
        public UnaExcepcion(string mensaje, Exception ex) : this (mensaje) { }
    }
}
