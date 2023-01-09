using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadística_deportiva__Ejercicio_4
{
    internal class Equipo
    {
        private short cantidadJugadores;

        private List<Jugador> jugadores;

        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            cantidadJugadores = cantidad;

            this.nombre = nombre;
        }

        public static bool operator +(Equipo equipo, Jugador jugador) 
        {
            if (equipo.jugadores.Count() < equipo.cantidadJugadores)
            {
                foreach (Jugador jug in equipo.jugadores)
                {
                    if (jug == jugador) 
                    {
                        return false;
                    }
                }
                
                equipo.jugadores.Add(jugador);

                equipo.cantidadJugadores++;

                return true;
            }

            return false;
        }

    }
}
