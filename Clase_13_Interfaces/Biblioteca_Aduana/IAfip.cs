using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Aduana
{
    public interface IAfip
    {
        public decimal Impuestos { get; }

        public decimal AplicarImpuestos();
    }
}
