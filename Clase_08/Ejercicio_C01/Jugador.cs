using System;
using System.Text;

namespace Ejercicio_C01
{
    /// <summary>
    /// Clase que representa un jugador en un equipo deportivo.
    /// </summary>
    public class Jugador
    {
        // Atributos

        /// <summary>
        /// DNI del jugador.
        /// </summary>
        private int dni;

        /// <summary>
        /// Nombre del jugador.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Número de partidos jugados por el jugador.
        /// </summary>
        private int partidosJugados;

        /// <summary>
        /// Número total de goles marcados por el jugador.
        /// </summary>
        private int totalGoles;

        /// <summary>
        /// Promedio de goles por partido del jugador.
        /// </summary>
        private float promedioGoles;

        // Constructores

        /// <summary>
        /// Constructor privado de la clase Jugador. Inicializa los atributos.
        /// </summary>
        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
            this.promedioGoles = 0;
        }

        /// <summary>
        /// Constructor de la clase Jugador que inicializa el DNI y el nombre del jugador.
        /// </summary>
        /// <param name="dni">El DNI del jugador.</param>
        /// <param name="nombre">El nombre del jugador.</param>
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        /// <summary>
        /// Constructor de la clase Jugador que inicializa el DNI, el nombre, el total de goles y los partidos jugados.
        /// </summary>
        /// <param name="dni">El DNI del jugador.</param>
        /// <param name="nombre">El nombre del jugador.</param>
        /// <param name="totalGoles">El número total de goles marcados por el jugador.</param>
        /// <param name="totalPartidos">El número total de partidos jugados por el jugador.</param>
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        // Métodos de instancia

        /// <summary>
        /// Calcula el promedio de goles por partido del jugador.
        /// </summary>
        /// <returns>El promedio de goles por partido.</returns>
        public float GetPromedioGoles()
        {
            this.promedioGoles = partidosJugados > 0 ? (float)totalGoles / partidosJugados : 0;
            return promedioGoles;
        }

        /// <summary>
        /// Devuelve una representación en forma de cadena de los datos del jugador.
        /// </summary>
        /// <returns>Una cadena con los datos del jugador.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" *** Datos del jugador *** ");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Total goles: {totalGoles}");
            sb.AppendLine($"Promedio de gol: {promedioGoles}");
            return sb.ToString();
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Compara dos jugadores por su DNI para verificar si son iguales.
        /// </summary>
        /// <param name="jugador1">El primer jugador a comparar.</param>
        /// <param name="jugador2">El segundo jugador a comparar.</param>
        /// <returns>True si los DNI son iguales, de lo contrario, false.</returns>
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if (jugador1 is not null && jugador2 is not null)
                return jugador1.dni == jugador2.dni;
            return false;
        }

        /// <summary>
        /// Compara dos jugadores por su DNI para verificar si son diferentes.
        /// </summary>
        /// <param name="jugador1">El primer jugador a comparar.</param>
        /// <param name="jugador2">El segundo jugador a comparar.</param>
        /// <returns>True si los DNI son diferentes, de lo contrario, false.</returns>
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
