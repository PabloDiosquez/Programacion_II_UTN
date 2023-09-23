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
            SetTinta(tinta);

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
            int nivelTintaActual = this.tinta + tinta;

            if (nivelTintaActual >= 0 && nivelTintaActual <= cantidadMaximaDeTinta)
            {
                this.tinta = (short)nivelTintaActual;
            }
        }

        public void Recargar() 
        {
            SetTinta(cantidadMaximaDeTinta);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = string.Empty;

            if (tinta == 0) return false;

            while (tinta > 0 && gasto > 0)
            {
                Console.ForegroundColor = GetColor();

                dibujo += "*";

                SetTinta(-1);
            
                gasto -= 1;
            }

            return true;
        }
    }
}
