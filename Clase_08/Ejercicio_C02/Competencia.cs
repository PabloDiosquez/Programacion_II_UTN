using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_C02
{
    /// <summary>
    /// Clase que representa una competencia de vehículos de carrera.
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
        private List<VehiculoDeCarrera> competidores;

        /// <summary>
        /// Tipo de competencia.
        /// </summary>
        private TipoCompetencia tipoCompetencia;

        // Constructores

        /// <summary>
        /// Constructor privado de la clase Competencia. Inicializa la lista de competidores.
        /// </summary>
        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        /// <summary>
        /// Constructor público de la clase Competencia. Establece la cantidad de vueltas y competidores, e inicializa la lista de competidores.
        /// </summary>
        /// <param name="cantidadVueltas">Cantidad de vueltas en la competencia.</param>
        /// <param name="cantidadCompetidores">Cantidad de competidores en la competencia.</param>
        /// <param name="tipo">Tipo de competencia (calificación, carrera, etc.).</param>
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipoCompetencia = tipo;
        }

        // Indexador

        public VehiculoDeCarrera this[int indice]
        {
            get { return this.Competidores[indice]; }
        }

        // Getters y Setters 

        /// <summary>
        /// Obtiene y establece la cantidad de competidores en la competencia.
        /// </summary>
        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set { this.cantidadCompetidores = (short)((value > 0) ? value : 0); }
        }

        /// <summary>
        /// Obtiene y establece la cantidad de vueltas en la competencia.
        /// </summary>
        public short CantidadVueltas
        {
            get { return cantidadVueltas; }
            set { this.cantidadVueltas = (short)((value > 0) ? value : 0); }
        }

        /// <summary>
        /// Obtiene la lista de competidores en la competencia.
        /// </summary>
        public List<VehiculoDeCarrera> Competidores { get { return competidores; } }

        /// <summary>
        /// Obtiene o establece el tipo de competencia (F1 o Motocross).
        /// </summary>
        public TipoCompetencia Tipo
        {
            get { return tipoCompetencia; }
            set { tipoCompetencia = value; }
        }

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
            sb.AppendLine($"Tipo de competencia: {Tipo}");
            sb.AppendLine($"Cantidad de vueltas: {CantidadVueltas}");
            foreach (VehiculoDeCarrera auto in Competidores)
            {
                sb.AppendLine(auto.ToString());
            }
            return sb.ToString();
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Sobrecarga del operador de igualdad (==) para comparar una competencia con 
        /// un vehículoy determinar si el auto está en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia en la que se busca el auto.</param>
        /// <param name="vehiculoBuscado">Vehículo que se busca.</param>
        /// <returns>True si el vehículo está en la competencia, false en caso contrario.</returns>
        public static bool operator ==(Competencia competencia, VehiculoDeCarrera vehiculoBuscado)
        {
            if (competencia is null) return false;
            foreach (VehiculoDeCarrera vehiculo in competencia.Competidores)
            {
                if (vehiculoBuscado == vehiculo) return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad (!=) para comparar una competencia con un 
        /// vehículo y determinar si no está en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia en la que se busca el auto.</param>
        /// <param name="vehiculo">Auto de Fórmula 1 que se busca.</param>
        /// <returns>True si el auto no está en la competencia, false en caso contrario.</returns>
        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }

        /// <summary>
        /// Sobrecarga del operador de adición (+) para agregar un vehículo a la competencia
        /// si hay espacio disponible.
        /// </summary>
        /// <param name="competencia">Competencia a la que se agrega el auto.</param>
        /// <param name="vehiculo">Vehículo que se agrega a la competencia.</param>
        /// <returns>True si el auto se agrega con éxito, false en caso contrario.</returns>
        public static bool operator +(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            if (competencia.Competidores.Count < competencia.cantidadCompetidores)
            {
                if (competencia == vehiculo) return false;
                vehiculo.EnCompetencia = true;
                vehiculo.VueltasRestantes = competencia.CantidadVueltas;
                vehiculo.CantidadCombustible = (short)new Random().Next(15, 101);
                competencia.Competidores.Add(vehiculo);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador de sustracción (-) para eliminar un vehículo de la
        /// competencia.
        /// </summary>
        /// <param name="competencia">Competencia de la que se elimina el auto.</param>
        /// <param name="vehiculoBuscado">Vehículo que se elimina de la competencia.</param>
        public static bool operator -(Competencia competencia, VehiculoDeCarrera vehiculoBuscado)
        {
            if (competencia == vehiculoBuscado)
            {
                competencia.Competidores.Remove(vehiculoBuscado);
                return true;
            }
            return false;
        }
    }
}
