using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    /// <summary>
    /// Modela un punto de Z2 = {(x, y) : x, y e Z}
    /// </summary>
    internal class Punto
    {
        // Atributos

        private int x;

        private int y;

        // Constructor ����‍
        public Punto(int x, int y)
        {
            this.x = x;

            this.y = y;
        }

        // Métodos de instancia (sólo lectura)

        /// <summary>
        /// Describe la coordenada x de un punto.
        /// </summary>
        /// <returns>Coordenada x (int)</returns>
        public int GetX()
        {
            return x;
        }

        /// <summary>
        /// Describe la coordenada y de unn punto.
        /// </summary>
        /// <returns>Coordenada y (int)</returns>
        public int GetY()
        {
            return y;
        }
     }
}
