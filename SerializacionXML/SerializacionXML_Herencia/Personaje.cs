using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML_Herencia
{
    /// <summary>
    /// Clase que representa a un personaje con nombre y nivel.
    /// </summary>
    public class Personaje
    {
        // Atributos privados

        // Nombre del personaje
        private string nombre;

        // Nivel del personaje
        private int nivel;

        // Constructores

        /// <summary>
        /// Constructor por defecto que inicializa un personaje sin valores.
        /// </summary>
        public Personaje() { }

        /// <summary>
        /// Constructor que inicializa un personaje con nombre y nivel específicos.
        /// </summary>
        /// <param name="nombre">Nombre del personaje.</param>
        /// <param name="nivel">Nivel del personaje.</param>
        public Personaje(string nombre, int nivel)
        {
            this.nombre = nombre; // Asigna el nombre proporcionado al atributo 'nombre'
            this.nivel = nivel; // Asigna el nivel proporcionado al atributo 'nivel'
        }

        // Propiedades públicas

        /// <summary>
        /// Propiedad para acceder y modificar el nombre del personaje.
        /// </summary>
        public string Nombre
        {
            get { return nombre; } // Obtiene el nombre del personaje
            set { nombre = value; } // Asigna un valor al nombre del personaje
        }

        /// <summary>
        /// Propiedad para acceder y modificar el nivel del personaje.
        /// </summary>
        public int Nivel
        {
            get { return nivel; } // Obtiene el nivel del personaje
            set { nivel = value; } // Asigna un valor al nivel del personaje
        }

        // Métodos de instancia

        /// <summary>
        /// Sobrescribe el método ToString para mostrar los detalles del personaje.
        /// </summary>
        /// <returns>Detalles del personaje en formato de cadena.</returns>
        public override string ToString()
        {
            return $"Nombre: {Nombre} -- Nivel: {Nivel}"; // Retorna una cadena con el nombre y nivel del personaje
        }
    }
}
