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
            foreach (T eq in torneo.equipos)
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

        public static bool operator +(Torneo<T> torneo, Equipo equipo)
        {
            if (torneo is not null && equipo is not null && torneo != equipo)
            {
                torneo.equipos.Add((T)equipo);

                return true;    
            }

            return false;
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

            int marcadorA = rd.Next(0, 10);

            int marcadorB = rd.Next(0, 10);

            return $"{equipoA.Nombre}:{marcadorA} -- {equipoB.Nombre}:{marcadorB}";
        }

        public string JugarPartido
        {
            get
            {
                if (equipos.Count >= 2)
                {
                    Random rd = new Random();

                    T equipoA;

                    T equipoB;

                    do
                    {
                        equipoA = equipos[rd.Next(0, equipos.Count)];

                        equipoB = equipos[rd.Next(0, equipos.Count)];

                    } while (equipoA == equipoB);

                    return CalcularPartido(equipoA, equipoB);
                }

                return "La lista debe contener al menos dos equipos...";
            }
        }
    }
}
