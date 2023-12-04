using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculo
{
    public class Butaca
    {
        // Atributos

        public int Nro { get; set; }

        private double precio;

        // Constructor

        public Butaca(int nro, double precio)
        {
            Nro = nro;
            Precio = precio; // Utilizando el setter de Precio
        }

        // Propiedades
        public double Precio
        {
            get => precio;
            set => precio = (value >= 0) ? value : 0;
        }
    }
}
