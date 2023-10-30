using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01_Biblioteca
{
    /// <summary>
    /// Clase que representa una competencia de autos de Fórmula 1.
    /// </summary>
    public class Competencia
    {
        // Atributos 

        /// <summary>
        /// Cantidad de competidores en la competencia.
        /// </summary>
        private short cantidadCompetidores;

        /// <summary>
        /// Cantidad de vueltas en la competencia.
        /// </summary>
        private short cantidadVueltas;

        /// <summary>
        /// Lista de competidores en la competencia.
        /// </summary>
        private List<AutoF1> competidores;

        /// <summary>
        /// Obtiene la cantidad de competidores en la competencia.
        /// </summary>
        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }

        /// <summary>
        /// Obtiene la cantidad de vueltas en la competencia.
        /// </summary>
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }

        /// <summary>
        /// Obtiene la lista de competidores en la competencia.
        /// </summary>
        public List<AutoF1> Competidores { get => competidores; }

        // Constructor 

        /// <summary>
        /// Constructor privado de la clase Competencia que inicializa la lista de competidores.
        /// </summary>
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        /// <summary>
        /// Constructor de la clase Competencia que establece la cantidad de vueltas y competidores y llama al constructor privado.
        /// </summary>
        /// <param name="cantidadVueltas">Cantidad de vueltas en la competencia.</param>
        /// <param name="cantidadCompetidores">Cantidad de competidores en la competencia.</param>
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        // Métodos de instancia 

        /// <summary>
        /// Muestra los datos de la competencia y de sus competidores.
        /// </summary>
        /// <returns>Una cadena que contiene los datos de la competencia.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Datos de la Competencia ***");
            sb.AppendLine($"Cantidad de vueltas: {this.CantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores: {this.CantidadCompetidores}");
            foreach (AutoF1 auto in this.Competidores) auto.MostrarDatos();

            return sb.ToString();
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Agrega un auto a la competencia si hay espacio y no existe previamente en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia a la que se agrega el auto.</param>
        /// <param name="auto">Auto a agregar a la competencia.</param>
        /// <returns>Verdadero si el auto se agregó con éxito, falso en caso contrario.</returns>
        public static bool operator +(Competencia competencia, AutoF1 auto)
        {
            if (competencia.Competidores.Count == competencia.CantidadCompetidores
                || competencia == auto) return false;

            competencia.Competidores.Add(auto);

            auto.EnCompetencia = true;

            auto.VueltasRestantes = competencia.cantidadVueltas;

            auto.CantidadCombustible = (short)new Random().Next(15, 101);

            return true;
        }

        /// <summary>
        /// Quita un auto de la competencia si existe en la misma.
        /// </summary>
        /// <param name="competencia">Competencia de la que se quita el auto.</param>
        /// <param name="auto">Auto a quitar de la competencia.</param>
        /// <returns>Verdadero si el auto se quitó con éxito, falso en caso contrario.</returns>
        public static bool operator -(Competencia competencia, AutoF1 auto)
        {
            if (competencia != auto) return false;

            competencia.Competidores.Remove(auto);

            auto.EnCompetencia = false;

            auto.VueltasRestantes = 0;

            auto.CantidadCombustible = 0;

            return true;
        }

        /// <summary>
        /// Compara si un auto está en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia en la que se busca el auto.</param>
        /// <param name="autoBuscado">Auto que se busca en la competencia.</param>
        /// <returns>Verdadero si el auto se encuentra en la competencia, falso en caso contrario.</returns>
        public static bool operator ==(Competencia competencia, AutoF1 autoBuscado)
        {
            if (competencia is null || autoBuscado is null) return false;

            foreach (AutoF1 auto in competencia.Competidores)
            {
                if (auto == autoBuscado) return true;
            }
            return false;
        }

        /// <summary>
        /// Compara si un auto no está en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia en la que se busca el auto.</param>
        /// <param name="auto">Auto que se busca en la competencia.</param>
        /// <returns>Verdadero si el auto no se encuentra en la competencia, falso en caso contrario.</returns>
        public static bool operator !=(Competencia competencia, AutoF1 auto)
        {
            return !(competencia == auto);
        }
    }
}
