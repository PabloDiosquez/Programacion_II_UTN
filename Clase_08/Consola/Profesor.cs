using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    /// <summary>
    /// La clase <see cref="Profesor"/> representa a un docente universitario. Hereda de la clase <see cref="Persona"/>.
    /// </summary>
    public class Profesor : Persona
    {
        /// <summary>
        /// Campo privado que almacena la cátedra a la que el profesor está asignado.
        /// </summary>
        private string catedra;

        /// <summary>
        /// Constructor de la clase <see cref="Profesor"/> que acepta los datos básicos de la persona y la cátedra del profesor.
        /// </summary>
        /// <param name="nombre">El nombre del profesor.</param>
        /// <param name="apellido">El apellido del profesor.</param>
        /// <param name="dni">El número de DNI del profesor.</param>
        /// <param name="catedra">La cátedra a la que el profesor está asignado.</param>
        public Profesor(string nombre, string apellido, int dni, string catedra)
            : this(new Persona(nombre, apellido, dni), catedra)
        {
            // Propósito: Inicializa una instancia de la clase Profesor con información básica y la cátedra a la que está asignado.
            // Precondiciones: 
            // - El nombre no debe ser nulo ni vacío.
            // - El apellido no debe ser nulo ni vacío.
            // - El DNI debe ser un número entero válido.
            // - La cátedra no debe ser nula ni vacía.

            this.catedra = catedra;
        }

        /// <summary>
        /// Constructor de la clase <see cref="Profesor"/> que acepta una instancia de <see cref="Persona"/> y la cátedra del profesor.
        /// </summary>
        /// <param name="persona">Una instancia de la clase Persona que representa los datos básicos del profesor.</param>
        /// <param name="catedra">La cátedra a la que el profesor está asignado.</param>
        public Profesor(Persona persona, string catedra) : base(persona.Nombre, persona.Apellido, persona.Dni)
        {
            // Propósito: Inicializa una instancia de la clase Profesor a partir de una instancia de Persona y la cátedra a la que está asignado.
            // Precondiciones: La instancia de Persona no debe ser nula y la cátedra no debe ser nula ni vacía.

            this.catedra = catedra;
        }

        /// <summary>
        /// Propiedad pública para acceder y modificar la cátedra a la que el profesor está asignado.
        /// </summary>
        public string Catedra
        {
            get => catedra;
            set => catedra = value;
        }

        /// <summary>
        /// Método que simula la acción de corregir exámenes o trabajos, y devuelve un mensaje que indica que el profesor está corrigiendo.
        /// </summary>
        /// <returns>Un mensaje indicando que el profesor está corrigiendo.</returns>
        public string Corregir()
        {
            // Propósito: Simula la acción de corregir exámenes o trabajos.
            // Precondiciones: Ninguna.

            return "Corrigiendo...";
        }
    }
}
