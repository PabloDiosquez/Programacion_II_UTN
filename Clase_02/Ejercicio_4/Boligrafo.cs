using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Boligrafo
    {
        // Atributos 

        private const short cantidadMaximaDeTinta = 100;

        private ConsoleColor color;

        private short tinta;

        // Constructor 👷🏼‍

        public Boligrafo(short tinta, ConsoleColor color) 
        {
            this.tinta = tinta;

            this.color = color; 
        }

        // Métodos de instancia 

        public short GetTinta()
        {
            return tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        private void SetTinta(short tinta)
        {

        }

        public void Recargar() 
        {
            tinta = cantidadMaximaDeTinta;
        }
    }
}
