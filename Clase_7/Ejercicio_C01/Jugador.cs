using System;

namespace Ejercicio_C01
{
    /// <summary>
    /// Representa a un jugador de fútbol con información sobre su DNI, nombre, partidos jugados, goles totales y promedio de goles por partido.
    /// </summary>
    public class Jugador
    {
        // Atributos privados

        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        // Constructores

        /// <summary>
        /// Crea una instancia de Jugador con valores predeterminados para partidos jugados y goles totales.
        /// </summary>
        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        /// <summary>
        /// Crea una instancia de Jugador con un DNI y un nombre especificados.
        /// </summary>
        /// <param name="dni">El número de DNI del jugador.</param>
        /// <param name="nombre">El nombre del jugador.</param>
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        /// <summary>
        /// Crea una instancia de Jugador con un DNI, un nombre, goles totales y partidos jugados especificados.
        /// </summary>
        /// <param name="dni">El número de DNI del jugador.</param>
        /// <param name="nombre">El nombre del jugador.</param>
        /// <param name="totalGoles">El número total de goles del jugador.</param>
        /// <param name="totalPartidos">El número total de partidos jugados por el jugador.</param>
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        // Propiedades públicas

        /// <summary>
        /// Obtiene o establece el número de DNI del jugador.
        /// </summary>
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del jugador.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene el número de partidos jugados por el jugador.
        /// </summary>
        public int PartidosJugados
        {
            get { return partidosJugados; }
        }

        /// <summary>
        /// Obtiene el número total de goles marcados por el jugador.
        /// </summary>
        public int TotalGoles
        {
            get { return totalGoles; }
        }

        /// <summary>
        /// Obtiene el promedio de goles por partido del jugador.
        /// </summary>
        public float PromedioGoles
        {
            get
            {
                if (PartidosJugados > 0)
                    return (float)TotalGoles / PartidosJugados;
                return 0;
            }
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Compara si dos jugadores tienen el mismo número de DNI.
        /// </summary>
        /// <param name="jugador1">El primer jugador a comparar.</param>
        /// <param name="jugador2">El segundo jugador a comparar.</param>
        /// <returns>Verdadero si ambos jugadores tienen el mismo número de DNI, de lo contrario, falso.</returns>
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if (jugador1 is not null && jugador2 is not null)
                return jugador1.Dni == jugador2.Dni;
            return false;
        }

        /// <summary>
        /// Compara si dos jugadores tienen diferentes números de DNI.
        /// </summary>
        /// <param name="jugador1">El primer jugador a comparar.</param>
        /// <param name="jugador2">El segundo jugador a comparar.</param>
        /// <returns>Verdadero si los jugadores tienen diferentes números de DNI, de lo contrario, falso.</returns>
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
