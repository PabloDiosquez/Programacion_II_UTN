using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cartuchera
{
    internal class Boligrafo
    {
        private ConsoleColor colorTinta;

        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            tinta = unidades;
            
            colorTinta = color;
        }

        public void Escribir(string texto) 
        {
            foreach (char caracter in texto)
            {
                tinta -= 0.3F;
            }
        }
    }
}
