using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML
{
    /// <summary>
    /// Clase que representa a un personaje en un videojuego.
    /// </summary>
    public class Personaje
    {
        // Atributos

        /// <summary>
        /// Nombre del personaje.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Nivel del personaje.
        /// </summary>
        private int nivel;

        // Constructores

        /// <summary>
        /// Constructor predeterminado de la clase Personaje.
        /// </summary>
        public Personaje() { }

        /// <summary>
        /// Constructor que inicializa un objeto Personaje con un nombre y un nivel.
        /// </summary>
        /// <param name="nombre">El nombre del personaje.</param>
        /// <param name="nivel">El nivel del personaje.</param>
        public Personaje(string nombre, int nivel)
        {
            this.Nombre = nombre;
            this.Nivel = nivel;
        }

        // Propiedades

        /// <summary>
        /// Obtiene o establece el nombre del personaje.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el nivel del personaje.
        /// </summary>
        public int Nivel { get => nivel; set => nivel = value; }

        // Métodos de instancia

        /// <summary>
        /// Convierte el objeto Personaje en una cadena de texto que representa sus atributos.
        /// </summary>
        /// <returns>Una cadena que muestra el nombre y el nivel del personaje.</returns>
        public override string ToString()
        {
            return $"Nombre: {Nombre} -- Nivel: {Nivel}";
        }
    }
}
