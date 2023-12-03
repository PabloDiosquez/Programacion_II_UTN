using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClaseB: ClaseA
    {
        public override string ToString()
        {
            return $"Clase B {base.ToString()}";
        }
    }
}
