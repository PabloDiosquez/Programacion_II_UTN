using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01_Biblioteca
{
    /// <summary>
    /// Clase abstracta que representa un equipo.
    /// </summary>
    public abstract class Equipo
    {
        // Atributos 

        /// <summary>
        /// Obtiene o establece el nombre del equipo.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Obtiene o establece la fecha de creación del equipo.
        /// </summary>
        private DateTime fechaDeCreacion;

        // Constructor 

        /// <summary>
        /// Inicializa una nueva instancia de la clase Equipo con el nombre especificado.
        /// </summary>
        /// <param name="nombre">El nombre del equipo.</param>
        public Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece el nombre del equipo.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece la fecha de creación del equipo.
        /// </summary>
        public DateTime FechaDeCreacion
        {
            get { return fechaDeCreacion; }
            set { fechaDeCreacion = value; }
        }

        // Métodos de instancia 

        /// <summary>
        /// Obtiene una ficha descriptiva del equipo que incluye su nombre y fecha de creación en un formato específico.
        /// </summary>
        /// <returns>Una cadena que representa la ficha del equipo.</returns>
        public string Ficha()
        {
            return $"{this.Nombre} fundado el {this.FechaDeCreacion.ToString("dd/MM/yyyy")}";
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Comprueba si dos objetos de tipo Equipo son iguales en nombre y fecha de creación.
        /// </summary>
        /// <param name="equipo1">El primer equipo a comparar.</param>
        /// <param name="equipo2">El segundo equipo a comparar.</param>
        /// <returns>True si los equipos son iguales, de lo contrario, false.</returns>
        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            if (equipo1 is null || equipo2 is null) return false;

            return equipo1.nombre == equipo2.nombre && equipo1.fechaDeCreacion == equipo2.FechaDeCreacion;
        }

        /// <summary>
        /// Comprueba si dos objetos de tipo Equipo son diferentes en nombre o fecha de creación.
        /// </summary>
        /// <param name="equipo1">El primer equipo a comparar.</param>
        /// <param name="equipo2">El segundo equipo a comparar.</param>
        /// <returns>True si los equipos son diferentes, de lo contrario, false.</returns>
        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }
    }
}
