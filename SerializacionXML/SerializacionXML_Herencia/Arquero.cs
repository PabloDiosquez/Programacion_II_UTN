using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML_Herencia
{
    public class Arquero: Personaje
    {
        // Atributos

        private bool tieneArmadura;

        // Constructor
        public Arquero(string nombre, int nivel, bool tieneArmadura) : base(nombre, nivel)
        {
            this.tieneArmadura = tieneArmadura;
        }
    }
}
