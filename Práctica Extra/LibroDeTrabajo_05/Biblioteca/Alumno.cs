using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Alumno : Persona
    {
        // Atributos

        private int legajo;
        private DateTime fechaNacimiento;
        private List<Materia> materias;

        // Constructores

        /// <summary>
        /// Constructor principal de la clase Alumno.
        /// </summary>
        /// <param name="legajo">Número de legajo del alumno.</param>
        /// <param name="dni">Número de documento del alumno.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        public Alumno(int legajo, int dni, string nombre, string apellido) :
            base(dni, nombre, apellido)
        {
            this.legajo = legajo;
            this.materias = new List<Materia>();
        }

        /// <summary>
        /// Constructor secundario de la clase Alumno que incluye la fecha de nacimiento.
        /// </summary>
        /// <param name="legajo">Número de legajo del alumno.</param>
        /// <param name="dni">Número de documento del alumno.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del alumno.</param>
        public Alumno(int legajo, int dni, string nombre, string apellido, DateTime fechaNacimiento)
            : this(legajo, dni, nombre, apellido)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        // Propiedades

        /// <summary>
        /// Obtiene o establece el número de legajo del alumno.
        /// </summary>
        public int Legajo { get => legajo; set => legajo = value; }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento del alumno.
        /// </summary>
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        /// <summary>
        /// Obtiene o establece la lista de materias en las que el alumno está inscrito.
        /// </summary>
        public List<Materia> Materias { get => materias; set => materias = value; }

        // Métodos de instancia

        /// <summary>
        /// Inscribe al alumno en una materia.
        /// </summary>
        /// <param name="materia">Materia a la que se inscribirá el alumno.</param>
        public void InscribirseAMateria(Materia materia)
        {
            if (materia is null) throw new ArgumentNullException(nameof(materia));

            this.materias.Add(materia);
            materia.AlumnosInscriptos.Add(this);
        }

        /// <summary>
        /// Devuelve una representación en cadena de los datos del alumno.
        /// </summary>
        /// <returns>Cadena que representa los datos del alumno.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del alumno: Legajo {this.Legajo}");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Fecha de nacimiento: {this.FechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Materias: {this.VerMaterias()}");

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve una cadena que representa las materias en las que el alumno está inscrito.
        /// </summary>
        /// <returns>Cadena que representa las materias del alumno.</returns>
        private string VerMaterias()
        {
            List<string> nombresMaterias = new List<string>();

            foreach (Materia materia in this.materias)
            {
                nombresMaterias.Add(materia.Nombre);
            }

            return string.Join(", ", nombresMaterias);
        }
    }
}
