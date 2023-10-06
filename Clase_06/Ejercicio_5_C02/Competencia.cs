using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_C02
{
    public class Competencia
    {
        // Atributos

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        // Constructor

        /// <summary>
        /// Constructor privado para inicializar la lista de competidores.
        /// </summary>
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        /// <summary>
        /// Constructor público para crear una instancia de Competencia con la cantidad de vueltas y competidores especificados.
        /// </summary>
        /// <param name="cantidadVueltas">Cantidad de vueltas en la competencia.</param>
        /// <param name="cantidadCompetidores">Cantidad máxima de competidores permitidos.</param>
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        // Métodos de instancia

        /// <summary>
        /// Obtiene la lista de competidores en la competencia.
        /// </summary>
        /// <returns>Lista de competidores.</returns>
        public List<AutoF1> GetCompetidores()
        {
            return competidores;
        }

        /// <summary>
        /// Obtiene la cantidad de vueltas de la competencia.
        /// </summary>
        /// <returns>Cantidad de vueltas.</returns>
        public short GetCantidadVueltas()
        {
            return cantidadVueltas;
        }

        /// <summary>
        /// Muestra los datos de la competencia, incluyendo la cantidad de competidores, la cantidad de vueltas y la información de los competidores.
        /// </summary>
        /// <returns>Una cadena de texto con los datos de la competencia.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("*** Datos de la competencia ***");
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {cantidadVueltas}");
            sb.AppendLine("*** Competidores ***\n");
            foreach (AutoF1 competidor in competidores)
            {
                sb.AppendLine($"{competidor.MostrarDatos()}\n");
            }
            return sb.ToString();
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Comprueba si un automóvil está en la lista de competidores de la competencia.
        /// </summary>
        /// <param name="competencia">La competencia en la que se busca el automóvil.</param>
        /// <param name="auto">El automóvil que se busca.</param>
        /// <returns>True si el automóvil está en la competencia, false si no lo está.</returns>
        public static bool operator ==(Competencia competencia, AutoF1 auto)
        {
            return competencia.GetCompetidores().Contains(auto);
        }

        /// <summary>
        /// Comprueba si un automóvil no está en la lista de competidores de la competencia.
        /// </summary>
        /// <param name="competencia">La competencia en la que se busca el automóvil.</param>
        /// <param name="auto">El automóvil que se busca.</param>
        /// <returns>True si el automóvil no está en la competencia, false si está en la competencia.</returns>
        public static bool operator !=(Competencia competencia, AutoF1 auto)
        {
            return !(competencia == auto);
        }

        /// <summary>
        /// Agrega un automóvil a la lista de competidores de la competencia si hay espacio y no está en la competencia.
        /// </summary>
        /// <param name="competencia">La competencia a la que se agrega el automóvil.</param>
        /// <param name="auto">El automóvil que se agrega.</param>
        /// <returns>True si el automóvil se agregó con éxito, false si no se pudo agregar.</returns>
        public static bool operator +(Competencia competencia, AutoF1 auto)
        {
            if (competencia.GetCompetidores().Count < competencia.cantidadCompetidores)
            {
                if (competencia == auto) return false;

                auto.SetEnCompetencia(true);
                auto.SetVueltasRestantes(competencia.GetCantidadVueltas());
                auto.SetCantidadDeCombustible((short)new Random().Next(1, 101));

                competencia.competidores.Add(auto);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Remueve un automóvil de la lista de competidores de la competencia si está en la competencia.
        /// </summary>
        /// <param name="competencia">La competencia de la que se remueve el automóvil.</param>
        /// <param name="auto">El automóvil que se remueve.</param>
        /// <returns>True si el automóvil se removió con éxito, false si no se pudo remover.</returns>
        public static bool operator -(Competencia competencia, AutoF1 auto)
        {
            if (competencia == auto)
            {
                competencia.GetCompetidores().Remove(auto);
                return true;
            }
            return false;
        }
    }
}
