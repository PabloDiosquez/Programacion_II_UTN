using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioI01_Biblioteca
{
    public class Torneo<T> 
        where T: Equipo  
    {
        // Atributos 

        private string nombre;

        private List<T> equipos;

        // Constructor 

        public Torneo(string nombre)
        {
            this.nombre = nombre;

            equipos = new List<T>();
        }

        // Propiedades 

        public string Nombre { get; set; }

        public List<T> Equipos { get; }

        // Métodos de instancia 

        public static bool operator ==(Torneo<T> torneo, Equipo equipoBuscado)
        {
            if (torneo.equipos.Count == 0 || equipoBuscado is not T) return false;

            foreach (Equipo equipo in torneo.equipos)
            {
                if(equipo == equipoBuscado) return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, Equipo equipo)
        {
            if (torneo != equipo && equipo is T) 
            {
                torneo.equipos.Add((T)equipo);

                return true;
            }
            return false;
        }

        // Métodos de instancia 

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*** Datos del Torneo ***");

            sb.AppendLine($"Nombre: {this.Nombre}");

            sb.AppendLine("Equipos:");

            foreach (Equipo equipo in this.Equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }

            return sb.ToString();
        }

        public string CalcularPartido(T equipo1, T equipo2)
        {
            if(equipo1 is EquipoFutbol && equipo2 is EquipoFutbol) return CalcularPartido(equipo1, equipo2);

            if(equipo1 is EquipoBasquet && equipo2 is EquipoBasquet) return CalcularPartido(equipo1, equipo2);

            return string.Empty;
        }




        private string CalcularPartido(EquipoFutbol equipo1, EquipoFutbol equipo2) 
        {
            return $"{equipo1.Nombre} [{new Random().Next(1, 11)}] -- {equipo2.Nombre} [{new Random().Next(1, 11)}]";
        }

        private string CalcularPartido(EquipoBasquet equipo1, EquipoBasquet equipo2) 
        {
            return $"{equipo1.Nombre} [{new Random().Next(1, 120)}] -- {equipo2.Nombre} [{new Random().Next(1, 120)}]";
        }

    }
}
