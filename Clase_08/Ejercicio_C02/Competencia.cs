using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02
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
        /// Lista de competidores (autos de Fórmula 1) en la competencia.
        /// </summary>
        private List<AutoF1> competidores;

        // Constructores

        /// <summary>
        /// Constructor privado de la clase Competencia. Inicializa la lista de competidores.
        /// </summary>
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        /// <summary>
        /// Constructor público de la clase Competencia. Establece la cantidad de vueltas y competidores, e inicializa la lista de competidores.
        /// </summary>
        /// <param name="cantidadVueltas">Cantidad de vueltas en la competencia.</param>
        /// <param name="cantidadCompetidores">Cantidad de competidores en la competencia.</param>
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        // Getters 

        /// <summary>
        /// Obtiene la cantidad de competidores en la competencia.
        /// </summary>
        public short CantidadCompetidores { get; }

        /// <summary>
        /// Obtiene la cantidad de vueltas en la competencia.
        /// </summary>
        public short CantidadVueltas { get; }

        /// <summary>
        /// Obtiene la lista de competidores en la competencia.
        /// </summary>
        public List<AutoF1> Competidores { get { return competidores; } }

        // Métodos de instancia 

        /// <summary>
        /// Sobrescribe el método ToString para representar la competencia como una cadena.
        /// </summary>
        /// <returns>Una cadena que representa la competencia.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" *** Datos Competencia ***");
            sb.AppendLine($"Cantidad de competidores: {CantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {CantidadVueltas}");
            foreach (AutoF1 auto in Competidores)
            {
                sb.AppendLine(auto.ToString());
            }
            return sb.ToString();
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Sobrecarga del operador de igualdad (==) para comparar una competencia con un auto de Fórmula 1 y determinar si el auto está en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia en la que se busca el auto.</param>
        /// <param name="autoBuscado">Auto de Fórmula 1 que se busca.</param>
        /// <returns>True si el auto está en la competencia, false en caso contrario.</returns>
        public static bool operator ==(Competencia competencia, AutoF1 autoBuscado)
        {
            if (competencia is null) return false;
            foreach (AutoF1 auto in competencia.Competidores)
            {
                if (autoBuscado == auto) return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad (!=) para comparar una competencia con un auto de Fórmula 1 y determinar si el auto no está en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia en la que se busca el auto.</param>
        /// <param name="auto">Auto de Fórmula 1 que se busca.</param>
        /// <returns>True si el auto no está en la competencia, false en caso contrario.</returns>
        public static bool operator !=(Competencia competencia, AutoF1 auto)
        {
            return !(competencia == auto);
        }

        /// <summary>
        /// Sobrecarga del operador de adición (+) para agregar un auto de Fórmula 1 a la competencia si hay espacio disponible.
        /// </summary>
        /// <param name="competencia">Competencia a la que se agrega el auto.</param>
        /// <param name="auto">Auto de Fórmula 1 que se agrega a la competencia.</param>
        /// <returns>True si el auto se agrega con éxito, false en caso contrario.</returns>
        public static bool operator +(Competencia competencia, AutoF1 auto)
        {
            if (competencia.Competidores.Count < competencia.cantidadCompetidores)
            {
                if (competencia == auto) return false;
                auto.EnCompetencia = true;
                auto.VueltasRestantes = competencia.CantidadVueltas;
                auto.CantidadCombustible = (short)new Random().Next(15, 101);
                competencia.Competidores.Add(auto);
                return true;
            }
            return false;
        }
    }
}
