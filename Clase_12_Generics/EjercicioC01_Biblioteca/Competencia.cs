using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01_Biblioteca
{
    /// <summary>
    /// Clase que representa una competencia de autos de Fórmula 1 o MotoCross.
    /// </summary>
    public class Competencia<V>
        where V : VehiculoDeCarrera
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
        private List<V> competidores;

        /// <summary>
        /// Tipo de la competencia (F1 o MotoCross).
        /// </summary>
        private TipoCompetencia tipoCompetencia;

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
        public List<V> Competidores { get => competidores; }

        /// <summary>
        /// Obtiene o establece el tipo de la competencia.
        /// </summary>
        public TipoCompetencia TipoCompetencia { get => tipoCompetencia; set => tipoCompetencia = value; }

        // Indexador 

        /// <summary>
        /// Acceso a un competidor en la competencia mediante un índice.
        /// </summary>
        /// <param name="indice">Índice del competidor.</param>
        /// <returns>El competidor en la posición indicada.</returns>
        public V this[int indice]
        {
            get
            {
                if (indice >= 0 && indice < this.competidores.Count)
                {
                    return this.competidores[indice];
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice fuera de rango.");
                }
            }
        }

        // Constructor 

        /// <summary>
        /// Constructor privado de la clase Competencia que inicializa la lista de competidores.
        /// </summary>
        private Competencia()
        {
            competidores = new List<V>();
        }

        /// <summary>
        /// Constructor de la clase Competencia que establece la cantidad de vueltas, competidores y tipo, y llama al constructor privado.
        /// </summary>
        /// <param name="cantidadVueltas">Cantidad de vueltas en la competencia.</param>
        /// <param name="cantidadCompetidores">Cantidad de competidores en la competencia.</param>
        /// <param name="tipo">Tipo de competencia (F1 o MotoCross).</param>
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipoCompetencia = tipo;
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
            sb.AppendLine($"Tipo Competencia: {this.TipoCompetencia}");
            foreach (V vehiculo in this.Competidores) vehiculo.MostrarDatos();

            return sb.ToString();
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Agrega un auto a la competencia si hay espacio y no existe previamente en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia a la que se agrega el auto.</param>
        /// <param name="auto">Auto a agregar a la competencia.</param>
        /// <returns>Verdadero si el auto se agregó con éxito, falso en caso contrario.</returns>
        public static bool operator +(Competencia<V> competencia, V vehiculo)
        {
            if (competencia.Competidores.Count == competencia.CantidadCompetidores
                || competencia == vehiculo) return false;

            competencia.Competidores.Add(vehiculo);

            vehiculo.EnCompetencia = true;

            vehiculo.VueltasRestantes = competencia.CantidadVueltas;

            vehiculo.CantidadCombustible = (short)new Random().Next(15, 101);

            return true;
        }

        /// <summary>
        /// Quita un auto de la competencia si existe en la misma.
        /// </summary>
        /// <param name="competencia">Competencia de la que se quita el auto.</param>
        /// <param name="auto">Auto a quitar de la competencia.</param>
        /// <returns>Verdadero si el auto se quitó con éxito, falso en caso contrario.</returns>
        public static bool operator -(Competencia<V> competencia, V vehiculo)
        {
            if (competencia != vehiculo) return false;

            competencia.Competidores.Remove(vehiculo);

            vehiculo.EnCompetencia = false;
            
            vehiculo.VueltasRestantes = 0;
            
            vehiculo.CantidadCombustible = 0;

            return true;
        }

        /// <summary>
        /// Compara si un vehículo de carrera está en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia en la que se busca el vehículo de carrera.</param>
        /// <param name="vehiculoBuscado">Vehículo de carrera que se busca en la competencia.</param>
        /// <returns>Verdadero si el vehículo de carrera se encuentra en la competencia, falso en caso contrario.</returns>
        public static bool operator ==(Competencia<V> competencia, V vehiculoBuscado)
        {
            if (competencia is null || vehiculoBuscado is null) return false;

            if (!VehiculoDeTipoCorrectoParaLaCompetencia(competencia, vehiculoBuscado))
                return false;

            foreach (VehiculoDeCarrera vehiculo in competencia.Competidores)
            {
                if (vehiculo == vehiculoBuscado) return true;
            }
            return false;
        }

        /// <summary>
        /// Compara si un vehículo de carrera no está en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia en la que se busca el vehículo de carrera.</param>
        /// <param name="vehiculo">Vehículo de carrera que se busca en la competencia.</param>
        /// <returns>Verdadero si el vehículo de carrera no se encuentra en la competencia, falso en caso contrario.</returns>
        public static bool operator !=(Competencia<V> competencia, V vehiculo)
        {
            return !(competencia == vehiculo);
        }

        /// <summary>
        /// Verifica si el tipo del vehículo es adecuado para la competencia.
        /// </summary>
        /// <param name="competencia">Competencia en la que se evalúa el tipo de vehículo.</param>
        /// <param name="vehiculo">Vehículo de carrera que se evalúa.</param>
        /// <returns>Verdadero si el tipo del vehículo es adecuado para la competencia, falso en caso contrario.</returns>
        private static bool VehiculoDeTipoCorrectoParaLaCompetencia(Competencia<V> competencia, V vehiculo)
        {
            return (competencia.TipoCompetencia == TipoCompetencia.F1 && vehiculo is AutoF1) 
                || (competencia.TipoCompetencia == TipoCompetencia.MotoCross && vehiculo is MotoCross);
        }
    }
}
