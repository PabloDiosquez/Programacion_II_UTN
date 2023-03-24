using System;

namespace Ejercicio_I04___Invento_argentino
{
    public class Boligrafo
    {

        private const short cantidadTintaMaxima = 100;
        
        private short tinta;

        private ConsoleColor color;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;

            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaResultante = (short)(this.tinta + tinta);

            if (tintaResultante >= 0 && tintaResultante <= cantidadTintaMaxima)
            {
                this.tinta = tintaResultante;
            }
        }

        public void Recargar()
        {
            tinta = cantidadTintaMaxima;
        }




















    }
}
