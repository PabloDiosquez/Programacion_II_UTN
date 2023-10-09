using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01
{
    /// <summary>
    /// Representa un equipo de fútbol con un nombre, una cantidad máxima de jugadores y una lista de jugadores.
    /// </summary>
    public class Equipo
    {
        // Atributos privados

        private string nombre;
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;

        // Constructores

        /// <summary>
        /// Crea una instancia de la clase Equipo con una lista de jugadores vacía.
        /// </summary>
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Crea una instancia de la clase Equipo con un nombre y una cantidad máxima de jugadores especificados.
        /// </summary>
        /// <param name="nombre">El nombre del equipo.</param>
        /// <param name="cantidadDeJugadores">La cantidad máxima de jugadores permitidos en el equipo.</param>
        public Equipo(string nombre, short cantidadDeJugadores)
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
        }

        // Propiedad Indexada

        /// <summary>
        /// Permite acceder a un jugador del equipo a través de su número de DNI.
        /// </summary>
        /// <param name="dni">El número de DNI del jugador que se desea obtener.</param>
        /// <returns>El jugador con el DNI especificado si se encuentra en el equipo.</returns>
        /// <exception cref="Exception">Se lanza una excepción si el DNI no pertenece a ningún jugador del equipo.</exception>
        public Jugador this[int dni]
        {
            get
            {
                foreach (Jugador jugador in jugadores)
                {
                    if (jugador.Dni == dni) return jugador;
                }
                throw new Exception("El DNI dado no pertenece a ningún jugador del equipo");
            }
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Agrega un nuevo jugador al equipo si hay espacio disponible y el jugador no está en el equipo.
        /// </summary>
        /// <param name="equipo">El equipo al que se desea agregar un nuevo jugador.</param>
        /// <param name="nuevoJugador">El jugador que se desea agregar al equipo.</param>
        /// <returns>Verdadero si el jugador se agrega exitosamente al equipo; de lo contrario, falso.</returns>
        public static bool operator +(Equipo equipo, Jugador nuevoJugador)
        {
            if (equipo.jugadores.Count < equipo.cantidadDeJugadores)
            {
                if (equipo != nuevoJugador)
                {
                    equipo.jugadores.Add(nuevoJugador);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Comprueba si un jugador está en el equipo.
        /// </summary>
        /// <param name="equipo">El equipo en el que se desea buscar al jugador.</param>
        /// <param name="jugadorBuscado">El jugador que se desea buscar en el equipo.</param>
        /// <returns>Verdadero si el jugador está en el equipo; de lo contrario, falso.</returns>
        public static bool operator ==(Equipo equipo, Jugador jugadorBuscado)
        {
            if (equipo.jugadores.Count == 0) return false;

            foreach (Jugador jugador in equipo.jugadores)
            {
                if (jugadorBuscado == jugador) return true;
            }

            return false;
        }

        /// <summary>
        /// Comprueba si un jugador no está en el equipo.
        /// </summary>
        /// <param name="equipo">El equipo en el que se desea buscar al jugador.</param>
        /// <param name="jugador">El jugador que se desea buscar en el equipo.</param>
        /// <returns>Verdadero si el jugador no está en el equipo; de lo contrario, falso.</returns>
        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }
    }
}
