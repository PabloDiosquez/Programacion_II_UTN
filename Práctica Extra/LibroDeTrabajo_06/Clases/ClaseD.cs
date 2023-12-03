using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClaseD : ClaseC
    {
        public override string ToString()
        {
            return $"Clase D {base.ToString()}";
        }
    }
}
