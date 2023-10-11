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

        // Constructores

        /// <summary>
        /// Constructor privado de la clase Jugador. Inicializa los atributos.
        /// </summary>
        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
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

        // Propiedades 

        public string Nombre
        {
            get { return this.Nombre; }

            set {this.nombre = (!string.IsNullOrEmpty(value)) ? value : "NN";}
        }

        public int Dni 
        {
            get { return this.dni; }
            set { this.dni = (value > 0 ? value : -1);  }
        }

        public int PartidosJugados
        {
            get { return partidosJugados; }
        }

        public int TotalGoles 
        {
            get { return totalGoles; }
        }

        public float PromedioGoles 
        {
            get 
            {
                if (this.PartidosJugados > 0) return this.TotalGoles / this.PartidosJugados;
                return 0;
            }
        }

        // Métodos de instancia

        /// <summary>
        /// Devuelve una representación en forma de cadena de los datos del jugador.
        /// </summary>
        /// <returns>Una cadena con los datos del jugador.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" *** Datos del jugador *** ");
            sb.AppendLine($"DNI: {Dni}");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Partidos jugados: {PartidosJugados}");
            sb.AppendLine($"Total goles: {TotalGoles}");
            sb.AppendLine($"Promedio de gol: {PromedioGoles}");
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
