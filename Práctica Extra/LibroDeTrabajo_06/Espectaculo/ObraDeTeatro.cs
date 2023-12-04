using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculo
{
    public class ObraDeTeatro : Espectaculo
    {
        // Atributos

        private string nombre;

        private double precio;

        // Constructores

        public ObraDeTeatro() { }

        public ObraDeTeatro(string nombre)
        {
            this.nombre = nombre;
        }

        public ObraDeTeatro(string nombre, double precio)
            : this(nombre)
        {
            this.precio = (precio > 0) ? precio : 0;
        }

        public ObraDeTeatro(ObraDeTeatro obra)
            : this(obra.nombre, obra.precio)
        {

        }

        // Propiedades 
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set { precio = (value > 0) ? value : 0; } } 

    }
}
