using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15_SerializacionJSON
{
    /// <summary>
    /// Clase que representa una mascota.
    /// </summary>
    public class Mascota
    {
        // Atributos 

        /// <summary>
        /// Nombre de la mascota.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Edad de la mascota.
        /// </summary>
        private int edad;

        /// <summary>
        /// Raza de la mascota.
        /// </summary>
        private string raza;

        /// <summary>
        /// Peso de la mascota.
        /// </summary>
        private double peso;

        /// <summary>
        /// Indica si la mascota tiene pelo.
        /// </summary>
        private bool tienePelo;

        // Constructor 
        /// <summary>
        /// Constructor de la clase Mascota.
        /// </summary>
        /// <param name="nombre">Nombre de la mascota.</param>
        /// <param name="edad">Edad de la mascota.</param>
        /// <param name="raza">Raza de la mascota.</param>
        /// <param name="peso">Peso de la mascota.</param>
        /// <param name="tienePelo">Indicador de si la mascota tiene pelo.</param>
        public Mascota(string nombre, int edad, string raza, double peso, bool tienePelo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.raza = raza;
            this.peso = peso;
            this.tienePelo = tienePelo;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece el nombre de la mascota.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece la edad de la mascota.
        /// </summary>
        public int Edad { get => edad; set => edad = value; }

        /// <summary>
        /// Obtiene o establece la raza de la mascota.
        /// </summary>
        public string Raza { get => raza; set => raza = value; }

        /// <summary>
        /// Obtiene o establece el peso de la mascota.
        /// </summary>
        public double Peso { get => peso; set => peso = value; }

        /// <summary>
        /// Obtiene o establece si la mascota tiene pelo.
        /// </summary>
        public bool TienePelo { get => tienePelo; set => tienePelo = value; }

        // Métodos 

        /// <summary>
        /// Devuelve una representación en texto de la mascota.
        /// </summary>
        /// <returns>Información de la mascota en formato de texto.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Datos Mascota ***");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"Peso: {Peso}");
            sb.AppendLine($"Raza: {Raza}");
            sb.AppendLine($"¿Tiene pelo?: {TienePelo}");

            return sb.ToString();
        }
    }
}
