using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioI01_Biblioteca
{
    /// <summary>
    /// Clase genérica que representa un torneo que acepta equipos de tipo T, donde T debe ser una subclase de la clase Equipo.
    /// </summary>
    /// <typeparam name="T">El tipo de equipos que se aceptarán en el torneo.</typeparam>
    public class Torneo<T>
        where T : Equipo
    {
        // Atributos

        /// <summary>
        /// Nombre del torneo.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Lista de equipos que participan en el torneo.
        /// </summary>
        private List<T> equipos;

        // Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase Torneo con el nombre especificado.
        /// </summary>
        /// <param name="nombre">El nombre del torneo.</param>
        public Torneo(string nombre)
        {
            this.nombre = nombre;
            equipos = new List<T>();
        }

        // Propiedades

        /// <summary>
        /// Obtiene o establece el nombre del torneo.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene la lista de equipos que participan en el torneo.
        /// </summary>
        public List<T> Equipos
        {
            get { return equipos; }
        }

        // Métodos de instancia

        /// <summary>
        /// Comprueba si un equipo específico está inscrito en el torneo.
        /// </summary>
        /// <param name="torneo">El torneo en el que se realizará la comprobación.</param>
        /// <param name="equipoBuscado">El equipo que se está buscando.</param>
        /// <returns>True si el equipo está inscrito en el torneo, de lo contrario, false.</returns>
        public static bool operator ==(Torneo<T> torneo, Equipo equipoBuscado)
        {
            if (torneo.equipos.Count == 0 || equipoBuscado is not T) return false;

            foreach (Equipo equipo in torneo.equipos)
            {
                if (equipo == equipoBuscado) return true;
            }
            return false;
        }

        /// <summary>
        /// Comprueba si un equipo específico no está inscrito en el torneo.
        /// </summary>
        /// <param name="torneo">El torneo en el que se realizará la comprobación.</param>
        /// <param name="equipo">El equipo que se está buscando.</param>
        /// <returns>True si el equipo no está inscrito en el torneo, de lo contrario, false.</returns>
        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        /// <summary>
        /// Agrega un equipo al torneo si el equipo no está inscrito y es del tipo adecuado.
        /// </summary>
        /// <param name="torneo">El torneo al que se agregará el equipo.</param>
        /// <param name="equipo">El equipo que se agregará.</param>
        /// <returns>True si el equipo se agregó con éxito, de lo contrario, false.</returns>
        public static bool operator +(Torneo<T> torneo, Equipo equipo)
        {
            if (torneo != equipo && equipo is T)
            {
                torneo.equipos.Add((T)equipo);

                return true;
            }
            return false;
        }

        // Métodos de instancia

        /// <summary>
        /// Muestra los detalles del torneo, incluyendo su nombre y la lista de equipos participantes.
        /// </summary>
        /// <returns>Una cadena que representa los detalles del torneo.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*** Datos del Torneo ***");

            sb.AppendLine($"Nombre: {this.Nombre}");

            sb.AppendLine("Equipos:");

            foreach (Equipo equipo in this.Equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Juega un partido aleatorio entre dos equipos en el torneo.
        /// </summary>
        /// <returns>Una cadena que representa el resultado del partido.</returns>
        public string JugarPartido()
        {

            if (this.Equipos.Count < 2) return "La lista debe tener al menos dos equipos";

            while (true)
            {
                int indiceA = new Random().Next(0, this.Equipos.Count);

                int indiceB = new Random().Next(0, this.Equipos.Count);

                if (indiceA == indiceB) continue;

                return CalcularPartido(equipos[indiceA], equipos[indiceB]);
            }
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            if (equipo1 is EquipoFutbol && equipo2 is EquipoFutbol) return CalcularPartido(equipo1, equipo2);

            if (equipo1 is EquipoBasquet && equipo2 is EquipoBasquet) return CalcularPartido(equipo1, equipo2);

            return string.Empty;
        }

        private string CalcularPartido(EquipoFutbol equipo1, EquipoFutbol equipo2)
        {
            return $"{equipo1.Nombre} [{new Random().Next(1, 11)}] -- {equipo2.Nombre} [{new Random().Next(1, 11)}]";
        }

        private string CalcularPartido(EquipoBasquet equipo1, EquipoBasquet equipo2)
        {
            return $"{equipo1.Nombre} [{new Random().Next(1, 120)}] -- {equipo2.Nombre} [{new Random().Next(1, 120)}]";
        }
    }
}
