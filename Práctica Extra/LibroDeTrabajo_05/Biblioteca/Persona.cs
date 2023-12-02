using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase que representa a una persona con información básica como DNI, nombre y apellido.
    /// </summary>
    public class Persona : IComparable<Persona>
    {
        // Atributos 

        private int dni;
        private string nombre;
        private string apellido;

        // Constructor 

        /// <summary>
        /// Constructor de la clase Persona.
        /// </summary>
        /// <param name="dni">Número de documento de la persona.</param>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        public Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        // Propiedades

        /// <summary>
        /// Obtiene o establece el número de documento de la persona.
        /// </summary>
        public int Dni { get => dni; set => dni = value; }

        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el apellido de la persona.
        /// </summary>
        public string Apellido { get => apellido; set => apellido = value; }

        // Métodos de instancia

        /// <summary>
        /// Compara la persona actual con otra persona basándose en el número de documento (DNI).
        /// </summary>
        /// <param name="persona">La persona con la que se va a comparar.</param>
        /// <returns>True si el número de documento de la persona actual es igual al de la persona especificada; de lo contrario, false.</returns>
        public bool EsIgualA(Persona persona)
        {
            return this.dni == persona.dni;
        }

        /// <summary>
        /// Devuelve una representación en cadena de los datos de la persona.
        /// </summary>
        /// <returns>Cadena que representa los datos de la persona.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Nombre completo: {this.Apellido}, {this.Nombre}");

            return sb.ToString();
        }

        /// <summary>
        /// Compara la persona actual con otra persona basándose en el número de documento (DNI).
        /// </summary>
        /// <param name="other">La persona con la que se va a comparar.</param>
        /// <returns>Un valor que indica el orden relativo de los objetos que se comparan.</returns>
        public int CompareTo(Persona other)
        {
            // Comparación basada en el DNI
            return this.dni.CompareTo(other.dni);
        }
    }
}
