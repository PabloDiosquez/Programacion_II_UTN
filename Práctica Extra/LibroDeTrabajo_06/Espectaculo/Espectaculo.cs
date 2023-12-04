using System;

namespace Espectaculo
{
    public abstract class Espectaculo
    {
        // Atributos 

        private int cantidadButacas;

        // Constructor 

        public Espectaculo() 
        {
            this.cantidadButacas = 10;
        }

        // Propiedad de lectura

        public int CantidadButacas { get { return this.cantidadButacas; } }
    }
}
