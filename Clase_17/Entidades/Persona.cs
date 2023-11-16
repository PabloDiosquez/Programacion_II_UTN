using System;

namespace Entidades
{
    /// <summary>
    /// Representa a una persona con un nombre y un apellido.
    /// </summary>
    public class Persona
    {
        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        /// <value>
        /// El nombre de la persona.
        /// </value>
        private string nombre;

        /// <summary>
        /// Obtiene o establece el apellido de la persona.
        /// </summary>
        /// <value>
        /// El apellido de la persona.
        /// </value>
        private string apellido;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Persona"/>.
        /// </summary>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="apellido">El apellido de la persona.</param>
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        /// <value>
        /// El nombre de la persona.
        /// </value>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el apellido de la persona.
        /// </summary>
        /// <value>
        /// El apellido de la persona.
        /// </value>
        public string Apellido { get => apellido; set => apellido = value; }

        /// <summary>
        /// Devuelve una cadena que representa la persona actual.
        /// </summary>
        /// <returns>
        /// Cadena que representa la persona actual.
        /// </returns>
        public override string ToString()
        {
            return $"Nombre: {Nombre} -- Apellido: {Apellido}";
        }
    }
}
