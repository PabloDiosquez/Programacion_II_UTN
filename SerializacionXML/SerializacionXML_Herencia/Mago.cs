using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML_Herencia
{
    /// <summary>
    /// Clase que representa a un Mago, heredando de la clase Personaje.
    /// </summary>
    public class Mago : Personaje
    {
        // Atributos específicos del Mago

        // Indica si el Mago tiene armadura
        private bool tieneArmadura;

        // Constructor

        /// <summary>
        /// Constructor que inicializa un Mago con nombre, nivel y si tiene o no armadura.
        /// </summary>
        /// <param name="nombre">Nombre del Mago.</param>
        /// <param name="nivel">Nivel del Mago.</param>
        /// <param name="tieneArmadura">Indica si el Mago tiene armadura.</param>
        public Mago(string nombre, int nivel, bool tieneArmadura) : base(nombre, nivel)
        {
            this.tieneArmadura = tieneArmadura; // Asigna el valor de tener o no armadura al atributo 'tieneArmadura'
        }
    }
}
