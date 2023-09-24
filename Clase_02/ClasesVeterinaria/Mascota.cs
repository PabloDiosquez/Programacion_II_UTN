using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    /// <summary>
    /// Modela una mascota de una veterinaria.
    /// </summary>
    public class Mascota
    {
        // Atributos 

        /// <summary>
        /// Nombre de la mascota.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Especie de la mascota.
        /// </summary>
        private string especie;

        /// <summary>
        /// Fecha de nacimiento de la mascota.
        /// </summary>
        private DateTime fechaNacimiento;

        /// <summary>
        /// Lista de vacunas aplicadas a la mascota.
        /// </summary>
        private List<string> vacunas;

        // Constructor 🐕‍🦺

        /// <summary>
        /// Constructor de la clase <see cref="Mascota"/> que inicializa una nueva instancia de la mascota.
        /// </summary>
        /// <param name="nombre">El nombre de la mascota.</param>
        /// <param name="especie">La especie de la mascota.</param>
        /// <param name="fechaNacimiento">La fecha de nacimiento de la mascota.</param>
        public Mascota(string nombre, string especie, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNacimiento;
            vacunas = new List<string>();
        }

        // Métodos de instancia 

        /// <summary>
        /// Obtiene el nombre de la mascota.
        /// </summary>
        /// <returns>El nombre de la mascota.</returns>
        public string Nombre()
        {
            return nombre;
        }

        /// <summary>
        /// Obtiene la especie de la mascota.
        /// </summary>
        /// <returns>La especie de la mascota.</returns>
        public string Especie()
        {
            return especie;
        }

        /// <summary>
        /// Obtiene la fecha de nacimiento de la mascota formateada como "dd/mm/yyyy".
        /// </summary>
        /// <returns>La fecha de nacimiento de la mascota formateada como "dd/mm/yyyy".</returns>
        public string FechaDeNacimiento()
        {
            return fechaNacimiento.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Agrega una vacuna a la lista de vacunas de la mascota.
        /// </summary>
        /// <param name="vacuna">El nombre de la vacuna a agregar.</param>
        /// <returns><c>true</c> si se agregó la vacuna correctamente; de lo contrario, <c>false</c>.</returns>
        public bool AgregarVacuna(string vacuna)
        {
            if (!string.IsNullOrEmpty(vacuna))
            {
                vacunas.Add(vacuna);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica si la mascota tiene una vacuna específica.
        /// </summary>
        /// <param name="vacuna">El nombre de la vacuna a verificar.</param>
        /// <returns><c>true</c> si la mascota tiene la vacuna; de lo contrario, <c>false</c>.</returns>
        public bool TieneVacuna(string vacuna)
        {
            return vacunas.Contains(vacuna);
        }

        /// <summary>
        /// Obtiene una representación en cadena de las vacunas aplicadas a la mascota.
        /// </summary>
        /// <returns>Una cadena que representa las vacunas aplicadas a la mascota.</returns>
        public string VerVacunas()
        {
            if (vacunas.Count == 0)
            {
                return "Aún no tiene vacunas";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vacunas:");

            foreach (string vacuna in vacunas)
            {
                sb.AppendLine($" ** {vacuna} **");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Obtiene una representación en cadena de los datos de la mascota.
        /// </summary>
        /// <returns>Una cadena que representa los datos de la mascota.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" ** Datos Mascota **");
            sb.AppendLine($"Nombre: {Nombre()}");
            sb.AppendLine($"Especie: {Especie()}");
            sb.AppendLine($"Fecha de nacimiento: {FechaDeNacimiento()}");

            return sb.ToString();
        }

        /// <summary>
        /// Retorna el nombre de la mascota.
        /// </summary>
        /// <returns>El nombre de la mascota.</returns>
        public override string ToString()
        {
            return $"{Nombre()}";
        }

    }
}
