using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            //return torneo.equipos.Contains(equipo);

            foreach (Equipo eq in torneo.equipos)
            {
                if (eq == equipo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, Equipo equipo)
        {
            if (!(torneo == equipo))
            {
                torneo.equipos.Add((T)equipo);
            }

            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Torneo: {nombre}");

            foreach (T equipo in equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }
            
            return sb.ToString();
        }

        private string CalcularPartido(T equipoA, T equipoB)
        {
            Random rd = new Random();

            int scoreA = rd.Next(0, 10);

            int scoreB = rd.Next(0, 10);

            return $"{equipoA.Nombre}:{scoreA} -- {equipoB.Nombre}:{scoreB}";
        }

        
    }
}
