using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca_Torneo
{
    public class Torneo<T> where T : Equipo
    {
        private string nombre;

        private List<T> equipos;

        private Torneo()
        {
            equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            return torneo.equipos.Contains(equipo);
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        
    }
}
