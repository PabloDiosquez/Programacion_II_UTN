using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    /// <summary>
    /// La clase <see cref="Estudiante"/> representa a un estudiante universitario. Hereda de la clase <see cref="Persona"/>.
    /// </summary>
    public class Estudiante : Persona
    {
        /// <summary>
        /// Campo privado que almacena el número de legajo del estudiante.
        /// </summary>
        private int legajo;

        /// <summary>
        /// Campo privado que almacena una lista de materias que el estudiante está cursando.
        /// </summary>
        private List<Materia> materias;

        /// <summary>
        /// Constructor de la clase <see cref="Estudiante"/> que acepta el número de legajo, el nombre, el apellido y el DNI del estudiante.
        /// </summary>
        /// <param name="legajo">El número de legajo del estudiante.</param>
        /// <param name="nombre">El nombre del estudiante.</param>
        /// <param name="apellido">El apellido del estudiante.</param>
        /// <param name="dni">El número de DNI del estudiante.</param>
        public Estudiante(int legajo, string nombre, string apellido, int dni)
            : this(legajo, new Persona(nombre, apellido, dni))
        {
            // Propósito: Inicializa una instancia de la clase Estudiante con el número de legajo y datos básicos del estudiante.
            // Precondiciones:
            // - El número de legajo debe ser un número entero válido.
            // - El nombre no debe ser nulo ni vacío.
            // - El apellido no debe ser nulo ni vacío.
            // - El DNI debe ser un número entero válido.
        }

        /// <summary>
        /// Constructor de la clase <see cref="Estudiante"/> que acepta el número de legajo y una instancia de <see cref="Persona"/>.
        /// </summary>
        /// <param name="legajo">El número de legajo del estudiante.</param>
        /// <param name="persona">Una instancia de la clase Persona que representa los datos básicos del estudiante.</param>
        public Estudiante(int legajo, Persona persona) : base(persona.Nombre, persona.Apellido, persona.Dni)
        {
            // Propósito: Inicializa una instancia de la clase Estudiante a partir del número de legajo y una instancia de Persona.
            // Precondiciones: La instancia de Persona no debe ser nula.
            this.legajo = legajo;
            materias = new List<Materia>();
        }

        /// <summary>
        /// Método que simula la acción de estudiar y devuelve un mensaje que indica que el estudiante está estudiando.
        /// </summary>
        /// <returns>Un mensaje indicando que el estudiante está estudiando.</returns>
        public string Estudiar()
        {
            // Propósito: Simula la acción de estudiar.
            // Precondiciones: Ninguna.
            return "Estudiando... ";
        }

        /// <summary>
        /// Agrega una materia a la lista de materias que el estudiante está cursando.
        /// </summary>
        /// <param name="materia">La materia que se va a agregar.</param>
        public void AgregarMateria(Materia materia)
        {
            // Propósito: Agrega una materia a la lista de materias del estudiante.
            // Precondiciones: La materia no debe ser nula.
            materias.Add(materia);
        }

        /// <summary>
        /// Imprime por consola las materias que el estudiante está cursando en el cuatrimestre actual.
        /// </summary>
        public void MateriasQueCursa()
        {
            // Propósito: Imprime por consola las materias que el estudiante está cursando en el cuatrimestre actual.
            // Precondiciones: Ninguna.
            if (materias.Count > 0)
            {
                foreach (Materia materia in materias)
                {
                    Console.WriteLine(materia.Nombre);
                }
            }
            else
            {
                Console.WriteLine("El alumno NO cursa materias este cuatrimestre.");
            }
        }
    }
}
