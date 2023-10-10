using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    /// <summary>
    /// La clase <see cref="Materia"/> representa una materia o asignatura en el contexto de una institución educativa.
    /// </summary>
    public class Materia
    {
        /// <summary>
        /// Campo privado que almacena el nombre de la materia.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Campo privado que almacena el nombre de la carrera a la que pertenece la materia.
        /// </summary>
        private string carrera;

        /// <summary>
        /// Campo privado que almacena una referencia al profesor a cargo de la materia.
        /// </summary>
        private Profesor profesorACargo;

        /// <summary>
        /// Constructor de la clase <see cref="Materia"/> que acepta el nombre de la materia y el nombre de la carrera a la que pertenece.
        /// </summary>
        /// <param name="nombre">El nombre de la materia.</param>
        /// <param name="carrera">El nombre de la carrera a la que pertenece la materia.</param>
        public Materia(string nombre, string carrera)
        {
            // Propósito: Inicializa una instancia de la clase Materia con un nombre y el nombre de la carrera a la que pertenece.
            // Precondiciones:
            // - El nombre de la materia no debe ser nulo ni vacío.
            // - El nombre de la carrera no debe ser nulo ni vacío.

            this.Nombre = nombre;
            this.Carrera = carrera;
        }

        /// <summary>
        /// Propiedad pública para acceder y modificar el nombre de la materia.
        /// </summary>
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        /// <summary>
        /// Propiedad pública para acceder y modificar el nombre de la carrera a la que pertenece la materia.
        /// </summary>
        public string Carrera
        {
            get => carrera;
            set => carrera = value;
        }

        /// <summary>
        /// Asigna un profesor como responsable de la materia.
        /// </summary>
        /// <param name="profesor">El profesor que estará a cargo de la materia.</param>
        public void ProfesorACargo(Profesor profesor)
        {
            // Propósito: Asigna un profesor como responsable de la materia.
            // Precondiciones: El profesor no debe ser nulo.
            profesorACargo = profesor;
        }
    }
}
