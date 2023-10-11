using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01
{
    /// <summary>
    /// Clase que representa un equipo de jugadores.
    /// </summary>
    public class Equipo
    {
        // Campos

        /// <summary>
        /// Nombre del equipo.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Cantidad máxima de jugadores en el equipo.
        /// </summary>
        private short cantidadJugadores;

        /// <summary>
        /// Lista de jugadores en el equipo.
        /// </summary>
        private List<Jugador> jugadores;

        // Constructores 

        /// <summary>
        /// Constructor privado para inicializar la lista de jugadores.
        /// </summary>
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Constructor público para crear un equipo con nombre y cantidad de jugadores.
        /// </summary>
        /// <param name="nombre">Nombre del equipo.</param>
        /// <param name="cantidadJugadores">Cantidad máxima de jugadores en el equipo.</param>
        public Equipo(string nombre, short cantidadJugadores) : this()
        {
            this.nombre = nombre;
            this.cantidadJugadores = cantidadJugadores;
        }

        // Propiedades 

        /// <summary>
        /// Propiedad para obtener o establecer el nombre del equipo.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Propiedad para obtener la cantidad máxima de jugadores en el equipo.
        /// </summary>
        public short CantidadJugadores { get; }

        /// <summary>
        /// Propiedad para obtener la lista de jugadores en el equipo.
        /// </summary>
        public List<Jugador> Jugadores { get; }

        // Sobrecarga del operador +

        /// <summary>
        /// Sobrecarga del operador + para agregar un jugador al equipo si hay espacio disponible.
        /// </summary>
        /// <param name="equipo">Equipo al que se va a agregar el jugador.</param>
        /// <param name="jugador">Jugador que se va a agregar al equipo.</param>
        /// <returns>Devuelve true si se agregó el jugador con éxito, false si no se pudo agregar.</returns>
        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            if (equipo.Jugadores.Count < equipo.cantidadJugadores)
            {
                if (equipo == jugador) return false;
                equipo.Jugadores.Add(jugador);
                return true;
            }
            return false;
        }

        // Sobrecarga del operador == 

        /// <summary>
        /// Sobrecarga del operador de igualdad (==) para comprobar si un jugador está en el equipo.
        /// </summary>
        /// <param name="equipo">Equipo en el que se busca al jugador.</param>
        /// <param name="jugadorBuscado">Jugador que se busca en el equipo.</param>
        /// <returns>Devuelve true si el jugador se encuentra en el equipo, false en caso contrario.</returns>
        public static bool operator ==(Equipo equipo, Jugador jugadorBuscado)
        {
            foreach (Jugador jugador in equipo.Jugadores)
            {
                if (jugadorBuscado == jugador) return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad (!=) para comprobar si un jugador no está en el equipo.
        /// </summary>
        /// <param name="equipo">Equipo en el que se busca al jugador.</param>
        /// <param name="jugador">Jugador que se busca en el equipo.</param>
        /// <returns>Devuelve true si el jugador no se encuentra en el equipo, false en caso contrario.</returns>
        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }
    }
}
