using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Contabilidad
{
    internal class Recibo : Documento
    {
        public Recibo() : this(0)
        {
            
        }

        public Recibo(int numero) : base(numero)
        {

        }
    }
}
