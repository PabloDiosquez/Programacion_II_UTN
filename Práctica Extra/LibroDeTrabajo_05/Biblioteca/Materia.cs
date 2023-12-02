using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase que representa una materia con información adicional como nombre, día y hora, profesor a cargo y alumnos inscritos.
    /// </summary>
    public class Materia
    {
        // Atributos 

        private string nombre;
        private string diaYHora;
        private Profesor profesor;
        private List<Alumno> alumnosInscriptos;

        // Constructor

        /// <summary>
        /// Constructor de la clase Materia.
        /// </summary>
        /// <param name="nombre">Nombre de la materia.</param>
        /// <param name="diaYHora">Día y hora en la que se dicta la materia.</param>
        public Materia(string nombre, string diaYHora)
        {
            this.nombre = nombre;
            this.diaYHora = diaYHora;
            alumnosInscriptos = new List<Alumno>();
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece el nombre de la materia.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el día y la hora en la que se dicta la materia.
        /// </summary>
        public string DiaYHora { get => diaYHora; set => diaYHora = value; }

        /// <summary>
        /// Obtiene o establece el profesor a cargo de la materia.
        /// </summary>
        public Profesor Profesor { get => profesor; set => profesor = value; }

        /// <summary>
        /// Obtiene o establece la lista de alumnos inscritos en la materia.
        /// </summary>
        public List<Alumno> AlumnosInscriptos { get => alumnosInscriptos; set => alumnosInscriptos = value; }

        // Métodos 

        /// <summary>
        /// Devuelve una representación en cadena de los datos de la materia.
        /// </summary>
        /// <returns>Cadena que representa los datos de la materia.</returns>
        public override string ToString()
        {
            string profesorNombre = (this.Profesor != null) ? this.Profesor.Apellido : "N/A";
            return $"[Materia: {this.Nombre}, Día y hora: {this.DiaYHora}, Profesor a cargo: {profesorNombre}]";
        }
    }
}
