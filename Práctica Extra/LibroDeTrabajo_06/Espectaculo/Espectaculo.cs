using System;

namespace Espectaculo
{
    public abstract class Espectaculo
    {
        // Atributos 

        private int cantidadButacas;

        // Constructor 

        public Espectaculo(int cantidadButacas) 
        {
            this.cantidadButacas = cantidadButacas;
        }

        // Propiedad de lectura

        public int CantidadButacas { get { return this.cantidadButacas; } }
    }
}
