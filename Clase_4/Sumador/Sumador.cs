using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumador
{
    internal class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) { }


        public long Sumar(long num1, long num2) 
        {
            cantidadSumas++;

            return num1 + num2;
        }

        public string Sumar(string s1, string s2) 
        {
            cantidadSumas++;
            return s1 + s2; 
        }

        public int CantidadSumas() 
        {
            return cantidadSumas;
        }
    }
}
