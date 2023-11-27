using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_03
{
    /// <summary>
    /// Clase que representa a un alumno.
    /// </summary>
    public class Alumno
    {
        // Atributos 

        /// <summary>
        /// DNI (Documento Nacional de Identidad) del alumno.
        /// </summary>
        private int dni;

        /// <summary>
        /// Nombre de la escuela a la que pertenece el alumno.
        /// </summary>
        private string nombreEscuela;

        // Constructores 

        /// <summary>
        /// Constructor predeterminado de la clase Alumno.
        /// </summary>
        public Alumno()
        { }

        /// <summary>
        /// Constructor que inicializa un objeto Alumno con valores específicos.
        /// </summary>
        /// <param name="dni">DNI del alumno.</param>
        /// <param name="nombreEscuela">Nombre de la escuela.</param>
        public Alumno(int dni, string nombreEscuela)
        {
            this.dni = dni;
            this.nombreEscuela = nombreEscuela;
        }

        // Propiedades 

        /// <summary>
        /// Propiedad que obtiene o establece el DNI del alumno.
        /// </summary>
        public int Dni { get => dni; set => dni = value; }

        /// <summary>
        /// Propiedad que obtiene o establece el nombre de la escuela del alumno.
        /// </summary>
        public string NombreEscuela { get => nombreEscuela; set => nombreEscuela = value; }

        // Sobrecarga del método ToString()

        /// <summary>
        /// Convierte el objeto Alumno a su representación en forma de cadena.
        /// </summary>
        /// <returns>Cadena que representa el objeto Alumno.</returns>
        public override string ToString()
        {
            return $"[DNI: {this.Dni}, Escuela: {this.NombreEscuela}]";
        }
    }
}
