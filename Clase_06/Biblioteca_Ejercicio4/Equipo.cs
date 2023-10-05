using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio4
{
    /// <summary>
    /// Representa un equipo deportivo que puede contener un conjunto de jugadores.
    /// </summary>
    public class Equipo
    {
        // Atributos

        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        // Constructores

        /// <summary>
        /// Constructor privado para crear una instancia de Equipo con una lista de jugadores vacía.
        /// </summary>
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Constructor que inicializa una instancia de Equipo con la cantidad de jugadores y un nombre.
        /// </summary>
        /// <param name="cantidadDeJugadores">La cantidad máxima de jugadores que puede tener el equipo.</param>
        /// <param name="nombre">El nombre del equipo.</param>
        public Equipo(short cantidadDeJugadores, string nombre)
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        // Métodos de instancia

        /// <summary>
        /// Obtiene la cantidad de jugadores efectivos en el equipo.
        /// </summary>
        /// <returns>La cantidad de jugadores en el equipo.</returns>
        private int GetCantidadDeJugadoresEfectivos()
        {
            return jugadores.Count;
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Sobrecarga del operador '+' para agregar un jugador al equipo si hay espacio disponible.
        /// </summary>
        /// <param name="equipo">El equipo al que se intenta agregar el jugador.</param>
        /// <param name="jugador">El jugador que se intenta agregar al equipo.</param>
        /// <returns>True si se agrega con éxito, false si el equipo está completo.</returns>
        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            if (equipo.GetCantidadDeJugadoresEfectivos() < equipo.cantidadDeJugadores)
            {
                foreach (Jugador jugadorEfectivo in equipo.jugadores)
                {
                    if (jugador == jugadorEfectivo) return false;
                }

                equipo.jugadores.Add(jugador);

                return true;
            }
            return false;
        }
    }
}
