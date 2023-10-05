using System;
using System.Text;

namespace Biblioteca_Ejercicio4
{
    /// <summary>
    /// Representa a un jugador de un equipo deportivo.
    /// </summary>
    public class Jugador
    {
        // Atributos

        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        // Constructores

        /// <summary>
        /// Constructor privado para crear una instancia de Jugador.
        /// </summary>
        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }

        /// <summary>
        /// Constructor que inicializa un Jugador con DNI y nombre.
        /// </summary>
        /// <param name="dni">El número de DNI del jugador.</param>
        /// <param name="nombre">El nombre del jugador.</param>
        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        /// <summary>
        /// Constructor que inicializa un Jugador con DNI, nombre, total de goles y partidos jugados.
        /// </summary>
        /// <param name="dni">El número de DNI del jugador.</param>
        /// <param name="nombre">El nombre del jugador.</param>
        /// <param name="totalGoles">El total de goles del jugador.</param>
        /// <param name="partidosJugados">El número de partidos jugados por el jugador.</param>
        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        // Métodos

        /// <summary>
        /// Calcula y devuelve el promedio de goles por partido del jugador.
        /// </summary>
        /// <returns>El promedio de goles del jugador.</returns>
        public float GetPromedioGoles()
        {
            if (partidosJugados > 0)
            {
                promedioGoles = (float)totalGoles / partidosJugados;
            }
            return promedioGoles;
        }

        /// <summary>
        /// Muestra los datos del jugador en formato de cadena.
        /// </summary>
        /// <returns>Los datos del jugador como cadena.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Datos del Jugador ***");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Goles: {totalGoles}");
            sb.AppendLine($"Promedio de gol: {GetPromedioGoles()}");
            return sb.ToString();
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Compara si dos jugadores son iguales basados en su número de DNI.
        /// </summary>
        /// <param name="jugadorA">El primer jugador a comparar.</param>
        /// <param name="jugadorB">El segundo jugador a comparar.</param>
        /// <returns>True si los jugadores tienen el mismo DNI, de lo contrario, false.</returns>
        public static bool operator ==(Jugador jugadorA, Jugador jugadorB)
        {
            if (jugadorA is not null && jugadorB is not null) 
            {
                return jugadorA.dni == jugadorB.dni;
            }
            return false;
        }

        /// <summary>
        /// Compara si dos jugadores son diferentes basados en su número de DNI.
        /// </summary>
        /// <param name="jugadorA">El primer jugador a comparar.</param>
        /// <param name="jugadorB">El segundo jugador a comparar.</param>
        /// <returns>True si los jugadores tienen diferentes DNI, de lo contrario, false.</returns>
        public static bool operator !=(Jugador jugadorA, Jugador jugadorB)
        {
            return !(jugadorA == jugadorB);
        }
    }
}
