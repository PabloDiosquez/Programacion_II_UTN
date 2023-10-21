using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase base para representar a una persona.
    /// </summary>
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        /// <summary>
        /// Constructor de la clase Persona.
        /// </summary>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="apellido">El apellido de la persona.</param>
        /// <param name="dni">El número de identificación de la persona.</param>
        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        /// <summary>
        /// Método que representa la acción de caminar.
        /// </summary>
        /// <returns>Un mensaje indicando que la persona está caminando.</returns>
        public string Caminar()
        {
            return "Estoy caminando...";
        }
    }
}
