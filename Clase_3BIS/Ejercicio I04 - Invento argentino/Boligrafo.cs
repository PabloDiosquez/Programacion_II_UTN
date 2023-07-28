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

        /// <summary>
        ///El método Pintar resta la tinta gastada. El parámetro gasto representará la cantidad de unidades de tinta a utilizar y utilizará tanta tinta como tenga disponible sin quedar en negativo.
        /// </summary>
        /// <param name="gasto">Representa la cantidad de unidades de tinta a utilizarcomo unidades de tinta haya gastado</param>
        /// <param name="dibujo">Informa el resultado retornando tantos * como unidades de tinta haya gastado</param>
        /// <returns>Una cadena de **dibujo**</returns>
        public string Pintar(int gasto, string dibujo = "*")
        {
            string dibujoResultante = string.Empty;

            int cantidad = 0;

            while (tinta > 0 && cantidad < gasto)
            {
                dibujoResultante += dibujo;

                SetTinta(-1);

                cantidad++;
            }

            return dibujoResultante;
        }

    }
}
