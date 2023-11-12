using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase que representa a un alumno.
    /// </summary>
    public class Alumno
    {
        private string nombreCompleto; // Nombre completo del alumno.
        private int legajo; // Número de legajo del alumno.
        private short edad; // Edad del alumno.

        /// <summary>
        /// Constructor por defecto de la clase Alumno.
        /// </summary>
        public Alumno() { }

        /// <summary>
        /// Constructor de la clase Alumno con parámetros.
        /// </summary>
        /// <param name="nombreCompleto">Nombre completo del alumno.</param>
        /// <param name="legajo">Número de legajo del alumno.</param>
        /// <param name="edad">Edad del alumno.</param>
        public Alumno(string nombreCompleto, int legajo, short edad)
        {
            this.NombreCompleto = nombreCompleto;
            this.Legajo = legajo;
            this.Edad = edad;
        }

        /// <summary>
        /// Propiedad que encapsula el nombre completo del alumno.
        /// </summary>
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }

        /// <summary>
        /// Propiedad que encapsula el número de legajo del alumno.
        /// </summary>
        public int Legajo { get => legajo; set => legajo = value; }

        /// <summary>
        /// Propiedad que encapsula la edad del alumno.
        /// </summary>
        public short Edad { get => edad; set => edad = value; }

        /// <summary>
        /// Método que sobrescribe el comportamiento del método ToString() para la clase Alumno.
        /// </summary>
        /// <returns>Una cadena que representa al alumno con su nombre completo y legajo.</returns>
        public override string ToString()
        {
            return $"Nombre completo: {nombreCompleto} -- Legajo: {Legajo}";
        }
    }
}
