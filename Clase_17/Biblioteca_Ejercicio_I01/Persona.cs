using System;

namespace Biblioteca_Ejercicio_I01
{
    /// <summary>
    /// Clase que representa a una Persona con atributos como Id, Nombre y Apellido.
    /// </summary>
    public class Persona
    {
        // Atributos 

        private int id;

        private string nombre;

        private string apellido;

        // Constructores 

        /// <summary>
        /// Constructor que inicializa una nueva instancia de la clase Persona con un Id, Nombre y Apellido.
        /// </summary>
        /// <param name="id">El identificador único de la Persona.</param>
        /// <param name="nombre">El nombre de la Persona.</param>
        /// <param name="apellido">El apellido de la Persona.</param>
        public Persona(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            this.id = id;
        }

        /// <summary>
        /// Constructor que inicializa una nueva instancia de la clase Persona con un Nombre y Apellido.
        /// </summary>
        /// <param name="nombre">El nombre de la Persona.</param>
        /// <param name="apellido">El apellido de la Persona.</param>
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece el Id de la Persona.
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Obtiene o establece el Nombre de la Persona.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el Apellido de la Persona.
        /// </summary>
        public string Apellido { get => apellido; set => apellido = value; }

        // Sobrecarga del método ToString().

        /// <summary>
        /// Devuelve una representación de cadena de la Persona.
        /// </summary>
        /// <returns>Una cadena que representa la Persona.</returns>
        public override string ToString()
        {
            return $"[Id: {this.Id}, Nombre: {this.Nombre}, Apellido: {this.Apellido}]";
        }
    }
}
