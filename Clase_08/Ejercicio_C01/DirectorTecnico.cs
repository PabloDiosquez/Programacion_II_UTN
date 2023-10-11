using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01
{
    /// <summary>
    /// Clase que representa a un Director Técnico, que es una persona con una fecha de nacimiento.
    /// Hereda de la clase Persona.
    /// </summary>
    public class DirectorTecnico : Persona
    {
        // Atributos 

        /// <summary>
        /// Fecha de nacimiento del Director Técnico.
        /// </summary>
        private DateTime fechaNacimiento;

        // Constructores 

        /// <summary>
        /// Constructor privado que permite crear un Director Técnico con un nombre.
        /// </summary>
        /// <param name="nombre">Nombre del Director Técnico.</param>
        private DirectorTecnico(string nombre) : base(nombre)
        {
            this.Nombre = nombre;
        }

        /// <summary>
        /// Constructor que permite crear un Director Técnico con un nombre y una fecha de nacimiento.
        /// </summary>
        /// <param name="nombre">Nombre del Director Técnico.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del Director Técnico.</param>
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        // Propiedades 

        /// <summary>
        /// Propiedad para obtener la fecha de nacimiento del Director Técnico.
        /// </summary>
        public DateTime FechaNacimiento { get; }

        // Sobreescritura del Método ToString() de Persona

        /// <summary>
        /// Sobreescritura del método ToString para obtener una representación en forma de cadena del Director Técnico.
        /// </summary>
        /// <returns>Cadena que contiene el nombre, DNI y fecha de nacimiento del Director Técnico.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Fecha de Nacimiento: {FechaNacimiento}");

            return sb.ToString();
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Sobrecarga del operador de igualdad (==) para comparar dos Directores Técnicos.
        /// </summary>
        /// <param name="dt1">Primer Director Técnico a comparar.</param>
        /// <param name="dt2">Segundo Director Técnico a comparar.</param>
        /// <returns>Devuelve true si los Directores Técnicos tienen el mismo DNI y la misma fecha de nacimiento, o false en caso contrario.</returns>
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if (dt1 is not null && dt2 is not null) return dt1.Dni == dt2.Dni && dt1.FechaNacimiento == dt2.FechaNacimiento;
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad (!=) para comparar dos Directores Técnicos.
        /// </summary>
        /// <param name="dt1">Primer Director Técnico a comparar.</param>
        /// <param name="dt2">Segundo Director Técnico a comparar.</param>
        /// <returns>Devuelve true si los Directores Técnicos no tienen el mismo DNI o la misma fecha de nacimiento, o false en caso contrario.</returns>
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
