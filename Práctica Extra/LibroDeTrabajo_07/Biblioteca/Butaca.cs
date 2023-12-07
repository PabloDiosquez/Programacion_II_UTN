using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Estado
    {
        Libre,
        Ocupada,
    }
    public class Butaca
    {
        private int numero;

        private Estado estado;

        // Constructores 

        public Butaca(int numero, Estado estado)
        {
            this.numero = numero;

            this.estado = estado;
        }

        // Propiedades 
        public int Numero { get => numero; set => numero = value; }
        public Estado Estado { get => estado; set => estado = value; }
    }
}
