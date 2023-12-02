using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase que representa a un profesor con información adicional como legajo y materias que dicta.
    /// </summary>
    public class Profesor : Persona
    {
        // Atributos

        private int legajo;
        private List<Materia> materiasQueDicta;

        // Constructor 

        /// <summary>
        /// Constructor de la clase Profesor.
        /// </summary>
        /// <param name="legajo">Número de legajo del profesor.</param>
        /// <param name="dni">Número de documento del profesor.</param>
        /// <param name="nombre">Nombre del profesor.</param>
        /// <param name="apellido">Apellido del profesor.</param>
        public Profesor(int legajo, int dni, string nombre, string apellido)
            : base(dni, nombre, apellido)
        {
            this.legajo = legajo;
            materiasQueDicta = new List<Materia>();
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece el número de legajo del profesor.
        /// </summary>
        public int Legajo { get => legajo; set => legajo = value; }

        /// <summary>
        /// Obtiene o establece la lista de materias que dicta el profesor.
        /// </summary>
        public List<Materia> MateriasQueDicta { get => materiasQueDicta; set => materiasQueDicta = value; }

        // Métodos de instancia 

        /// <summary>
        /// Agrega una materia a la lista de materias que el profesor dicta.
        /// </summary>
        /// <param name="materia">Materia que se agrega a las materias dictadas por el profesor.</param>
        public void AgregarDictadoMateria(Materia materia)
        {
            if (materia is null) throw new ArgumentNullException(nameof(materia));

            this.materiasQueDicta.Add(materia);
            materia.Profesor = this;
        }

        /// <summary>
        /// Devuelve una representación en cadena de los datos del profesor.
        /// </summary>
        /// <returns>Cadena que representa los datos del profesor.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del profesor: Legajo {this.Legajo}");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Materias que dicta: {this.VerMaterias()}");

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve una cadena que representa las materias que el profesor dicta.
        /// </summary>
        /// <returns>Cadena que representa las materias dictadas por el profesor.</returns>
        private string VerMaterias()
        {
            List<string> nombresMaterias = new List<string>();

            foreach (Materia materia in this.materiasQueDicta)
            {
                nombresMaterias.Add(materia.Nombre);
            }

            return string.Join(", ", nombresMaterias);
        }
    }
}
