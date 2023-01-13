using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugadores_UI
{
    public class Jugador
    {
        private int dni;

        private string nombre;

        private int partidosJugados;

        private int totalGoles;

        private float promedioGoles;

        private Jugador()
        {
            partidosJugados = 0;

            totalGoles = 0;

            promedioGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;

            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
        {
            this.totalGoles = totalGoles;

            partidosJugados = totalPartidos;
        }

        public float ObtenerPromedioGoles() 
        {
            if (partidosJugados != 0) 
            {
                promedioGoles = totalGoles / (float)partidosJugados;    

                return promedioGoles;
            }

            return promedioGoles;
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Goles: {totalGoles}");

            return sb.ToString();
        }
    }
}
