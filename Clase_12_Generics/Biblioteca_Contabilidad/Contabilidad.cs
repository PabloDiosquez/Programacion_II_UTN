using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Contabilidad
{
    public class Contabilidad<T, U>
        where T : Documento
        where U : Documento , new()
    {
        private List<T> egresos;

        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();

            ingresos = new List<U>();   
        }

        public static bool operator +(Contabilidad<T, U> contabilidad, T recibo)
        {
            if (recibo is not null)
            {
                contabilidad.egresos.Add(recibo);
                return true;    
            }
            return false;

        }

        public static bool operator +(Contabilidad<T, U> contabilidad, U recibo)
        {
            if (recibo is not null)
            {
                contabilidad.ingresos.Add(recibo);
                return true;
            }
            return false;

        }
    }
}
