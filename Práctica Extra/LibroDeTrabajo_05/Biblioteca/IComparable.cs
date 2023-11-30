using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IComparable
    {
        public bool EsIgualA(Persona persona);
        public bool EsMayorQue(Persona persona);
        public bool EsMenorQue(Persona persona);
    }
}
