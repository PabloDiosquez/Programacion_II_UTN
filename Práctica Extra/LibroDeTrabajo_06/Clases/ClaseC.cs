using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClaseC : ClaseB
    {
        public override string ToString()
        {
            return $"Clase C {base.ToString()}";
        }
    }
}
