using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02_Biblioteca
{
    public class Recibo : Documento
    {
        // Constructor

        public Recibo() : this(0) { }

        public Recibo(int numero) : base(numero) { }
    }
}
