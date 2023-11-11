using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML_Herencia
{
    /// <summary>
    /// Clase que representa a un Arquero, que hereda de la clase Personaje.
    /// </summary>
    public class Arquero : Personaje
    {
        // Atributos privados específicos del Arquero

        // Indica si el arquero tiene armadura
        private bool tieneArmadura;

        // Constructor

        /// <summary>
        /// Constructor que inicializa un Arquero con nombre, nivel y si tiene o no armadura.
        /// </summary>
        /// <param name="nombre">Nombre del Arquero.</param>
        /// <param name="nivel">Nivel del Arquero.</param>
        /// <param name="tieneArmadura">Indica si el Arquero tiene armadura.</param>
        public Arquero(string nombre, int nivel, bool tieneArmadura) : base(nombre, nivel)
        {
            this.tieneArmadura = tieneArmadura; // Asigna el valor de tener o no armadura al atributo 'tieneArmadura'
        }
    }
}
