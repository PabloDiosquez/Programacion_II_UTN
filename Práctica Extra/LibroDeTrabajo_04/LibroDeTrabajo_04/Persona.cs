using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_04
{
    /// <summary>
    /// Representa a una persona con nombre, edad y DNI.
    /// </summary>
    public class Persona
    {
        // Campos o atributos 

        /// <summary>
        /// Almacena el nombre de la persona.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Almacena la edad de la persona.
        /// </summary>
        private int edad;

        /// <summary>
        /// Almacena el DNI (Documento Nacional de Identidad) de la persona.
        /// </summary>
        private int dni;

        // Constructores

        /// <summary>
        /// Constructor predeterminado de la clase Persona.
        /// </summary>
        public Persona() { }

        /// <summary>
        /// Constructor que inicializa una instancia de la clase Persona con nombre, edad y DNI.
        /// </summary>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="edad">La edad de la persona.</param>
        /// <param name="dni">El DNI (Documento Nacional de Identidad) de la persona.</param>
        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece la edad de la persona.
        /// </summary>
        public int Edad { get => edad; set => edad = value; }

        /// <summary>
        /// Obtiene o establece el DNI (Documento Nacional de Identidad) de la persona.
        /// </summary>
        public int Dni { get => dni; set => dni = value; }

        // Métodos de instancia 

        /// <summary>
        /// Compara la edad de la persona actual con otra persona.
        /// </summary>
        /// <param name="persona">La otra persona a comparar.</param>
        /// <returns>True si la persona actual es mayor en edad que la otra persona; de lo contrario, False.</returns>
        public bool EsMayorQue(Persona persona)
        {
            return this.Edad > persona.Edad;
        }

        /// <summary>
        /// Compara la edad de la persona actual con otra persona.
        /// </summary>
        /// <param name="persona">La otra persona a comparar.</param>
        /// <returns>True si la persona actual es menor en edad que la otra persona; de lo contrario, False.</returns>
        public bool EsMenorQue(Persona persona)
        {
            return this.Edad < persona.Edad;
        }

        // Sobrecarga del método ToString()

        /// <summary>
        /// Devuelve una cadena que representa la información de la persona en el formato "Nombre (Edad) DNI".
        /// </summary>
        /// <returns>Una cadena que representa la información de la persona.</returns>
        public override string ToString()
        {
            return $"{this.Nombre} ({this.Edad}) {this.Dni}";
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Compara dos instancias de Persona para determinar si son iguales.
        /// </summary>
        /// <param name="primerPersona">La primera persona a comparar.</param>
        /// <param name="segundaPersona">La segunda persona a comparar.</param>
        /// <returns>True si las personas son iguales; de lo contrario, False.</returns>
        public static bool operator ==(Persona primerPersona, Persona segundaPersona)
        {
            if (primerPersona is null || segundaPersona is null) return false;
            return primerPersona.Dni == segundaPersona.Dni && primerPersona.Nombre == segundaPersona.Nombre;
        }

        /// <summary>
        /// Compara dos instancias de Persona para determinar si son diferentes.
        /// </summary>
        /// <param name="primerPersona">La primera persona a comparar.</param>
        /// <param name="segundaPersona">La segunda persona a comparar.</param>
        /// <returns>True si las personas son diferentes; de lo contrario, False.</returns>
        public static bool operator !=(Persona primerPersona, Persona segundaPersona)
        {
            return !(primerPersona == segundaPersona);
        }

        /// <summary>
        /// Compara dos instancias de Persona para determinar si la primera es mayor en edad que la segunda.
        /// </summary>
        /// <param name="primerPersona">La primera persona a comparar.</param>
        /// <param name="segundaPersona">La segunda persona a comparar.</param>
        /// <returns>True si la primera persona es mayor en edad que la segunda; de lo contrario, False.</returns>
        public static bool operator >(Persona primerPersona, Persona segundaPersona)
        {
            return primerPersona.EsMayorQue(segundaPersona);
        }

        /// <summary>
        /// Compara dos instancias de Persona para determinar si la primera es menor en edad que la segunda.
        /// </summary>
        /// <param name="primerPersona">La primera persona a comparar.</param>
        /// <param name="segundaPersona">La segunda persona a comparar.</param>
        /// <returns>True si la primera persona es menor en edad que la segunda; de lo contrario, False.</returns>
        public static bool operator <(Persona primerPersona, Persona segundaPersona)
        {
            return primerPersona.EsMenorQue(segundaPersona);
        }
    }
}
