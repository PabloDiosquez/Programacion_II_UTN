using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01
{
    /// <summary>
    /// Clase que representa a una persona con atributos como DNI y nombre.
    /// </summary>
    public class Persona
    {
        // Atributos

        /// <summary>
        /// DNI (Documento Nacional de Identidad) de la persona.
        /// </summary>
        private int dni;

        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        private string nombre;

        // Constructores 

        /// <summary>
        /// Constructor que recibe solo el nombre de la persona.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Constructor que recibe el DNI y el nombre de la persona.
        /// </summary>
        /// <param name="dni">DNI de la persona.</param>
        /// <param name="nombre">Nombre de la persona.</param>
        public Persona(int dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        // Propiedades 

        /// <summary>
        /// Propiedad para obtener o establecer el DNI de la persona.
        /// </summary>
        public int Dni
        {
            get { return dni; }
            set { this.dni = (value > 0) ? value : -1; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el nombre de la persona.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = (!string.IsNullOrEmpty(value)) ? value : "NN"; }
        }

        // Métodos de instancia

        /// <summary>
        /// Método que devuelve una representación en forma de cadena de la persona.
        /// </summary>
        /// <returns>Cadena que contiene el DNI y el nombre de la persona.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {Dni}");
            sb.AppendLine($"Nombre: {Nombre}");
            return sb.ToString();
        }
    }
}
