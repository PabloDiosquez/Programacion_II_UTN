using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_03
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Clase que representa una competencia con alumnos inscritos.
    /// </summary>
    public class Competencia
    {
        // Atributos

        /// <summary>
        /// Lista de alumnos inscritos en la competencia.
        /// </summary>
        private List<Alumno> alumnosInscriptos;

        /// <summary>
        /// Total de alumnos inscritos en la competencia.
        /// </summary>
        private int totalInscritos;

        // Constructor 

        /// <summary>
        /// Constructor predeterminado de la clase Competencia.
        /// Inicializa la lista de alumnos inscritos y el total de inscritos.
        /// </summary>
        public Competencia()
        {
            this.alumnosInscriptos = new List<Alumno>();
            this.totalInscritos = 0;
        }

        // Propiedades 

        public List<string> Escuelas {get {return this.ObtenerEscuelas();} }

        // Métodos de instancia 

        /// <summary>
        /// Inscribir a un alumno en la competencia.
        /// </summary>
        /// <param name="alumno">El alumno a inscribir.</param>
        /// <returns>True si la inscripción fue exitosa, False si el alumno ya estaba inscrito.</returns>
        public bool InscribirAlumno(Alumno alumno)
        {
            if (!this.ExisteAlumno(alumno))
            {
                this.alumnosInscriptos.Add(alumno);
                this.totalInscritos++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Borrar a un alumno de la competencia.
        /// </summary>
        /// <param name="alumno">El alumno a borrar.</param>
        /// <returns>True si el borrado fue exitoso, False si el alumno no estaba inscrito.</returns>
        public bool BorrarAlumno(Alumno alumno)
        {
            if (this.ExisteAlumno(alumno))
            {
                this.alumnosInscriptos.Remove(alumno);
                this.totalInscritos--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Obtener el total de alumnos inscritos en la competencia.
        /// </summary>
        /// <returns>El total de alumnos inscritos.</returns>
        public int ObtenerTotalAlumnosInscriptos()
        {
            return this.totalInscritos;
        }

        /// <summary>
        /// Obtener el total de escuelas representadas por los alumnos inscritos.
        /// </summary>
        /// <returns>El total de escuelas.</returns>
        public int ObtenerTotalEscuelas()
        {
            return this.ObtenerEscuelas().Count();
        }

        /// <summary>
        /// Imprimir la lista de escuelas inscritas en la competencia.
        /// </summary>
        /// <returns>Una cadena que representa las escuelas inscritas.</returns>
        public string ImprimirEscuelas()
        {
            StringBuilder sb = new StringBuilder();

            List<string> escuelas = this.ObtenerEscuelas();

            escuelas.Sort();

            sb.AppendLine(" *** Escuelas inscriptas *** ");

            foreach (string escuela in escuelas)
            {
                sb.AppendLine(escuela);
            }

            return sb.ToString();
        }

        // Métodos privados

        /// <summary>
        /// Obtener una lista de escuelas representadas por los alumnos inscritos.
        /// </summary>
        /// <returns>Una lista de nombres de escuelas.</returns>
        private List<string> ObtenerEscuelas()
        {
            List<string> escuelas = new List<string>();

            foreach (Alumno alumno in this.alumnosInscriptos)
            {
                if (!escuelas.Contains(alumno.NombreEscuela))
                {
                    escuelas.Add(alumno.NombreEscuela);
                }
            }
            return escuelas;
        }

        /// <summary>
        /// Verificar si un alumno ya está inscrito en la competencia.
        /// </summary>
        /// <param name="alumno">El alumno a verificar.</param>
        /// <returns>True si el alumno está inscrito, False si no lo está.</returns>
        private bool ExisteAlumno(Alumno alumno)
        {
            foreach (Alumno alumnoInscripto in this.alumnosInscriptos)
            {
                if (alumno.Dni == alumnoInscripto.Dni) return true;
            }
            return false;
        }
    }
}
