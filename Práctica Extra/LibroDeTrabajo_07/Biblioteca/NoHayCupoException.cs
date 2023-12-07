using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NoHayCupoException : Exception
    {
        public NoHayCupoException(string mensaje) : base(mensaje) { }
    }
}
