using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadística_deportiva__Ejercicio_4
{
    internal class Jugador
    {
        private int dni;

        private string nombre;

        private int partidosJugados;

        private float promedioGoles;

        private int totalGoles;

        private Jugador()
        {
            partidosJugados = 0;

            totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this() 
        {
            this.dni = dni;

            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre) 
        {
            this.totalGoles = totalGoles;

            partidosJugados = totalPartidos;
        }

        public float ObtenerPromedioGoles() 
        {
            promedioGoles = totalGoles / partidosJugados;
            
            return promedioGoles;
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("### Datos del jugador ###");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Patidos jugados: {partidosJugados}");
            sb.AppendLine($"Promedio de goles: {promedioGoles}");
            sb.AppendLine($"Total partidos jugados: {partidosJugados}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2) 
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2) 
        {
            return !(j1 == j2);
        } 
    }
}
