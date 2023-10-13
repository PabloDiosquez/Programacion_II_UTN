using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02
{
    /// <summary>
    /// Clase que representa un vehículo de carrera.
    /// </summary>
    public class VehiculoDeCarrera
    {
        // Atributos 

        /// <summary>
        /// Cantidad de combustible del vehículo.
        /// </summary>
        protected short cantidadCombustible;

        /// <summary>
        /// Indica si el vehículo está en competencia.
        /// </summary>
        protected bool enCompetencia;

        /// <summary>
        /// Nombre de la escudería a la que pertenece el vehículo.
        /// </summary>
        protected string escuderia;

        /// <summary>
        /// Número identificativo del vehículo.
        /// </summary>
        protected short numero;

        /// <summary>
        /// Número de vueltas restantes en la competencia.
        /// </summary>
        protected short vueltasRestantes;

        // Constructor 

        /// <summary>
        /// Constructor de la clase VehiculoDeCarrera.
        /// </summary>
        /// <param name="numero">Número identificativo del vehículo.</param>
        /// <param name="escuderia">Nombre de la escudería a la que pertenece el vehículo.</param>
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;

            this.escuderia = escuderia;

            this.enCompetencia = false;

            this.cantidadCombustible = 0;

            this.vueltasRestantes = 0;  

        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece la cantidad de combustible del vehículo.
        /// </summary>
        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { this.cantidadCombustible = (value > 0) ? value : (short)0; }
        }

        /// <summary>
        /// Obtiene o establece si el vehículo está en competencia.
        /// </summary>
        public bool EnCompetencia { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de la escudería a la que pertenece el vehículo.
        /// </summary>
        public string Escuderia
        {
            get { return escuderia; }
            set { this.escuderia = (!string.IsNullOrEmpty(value)) ? value : string.Empty; }
        }

        /// <summary>
        /// Obtiene o establece el número identificativo del vehículo.
        /// </summary>
        public int Numero
        {
            get { return numero; }
            set { this.numero = (short)((value > 0) ? value : 0); }
        }

        /// <summary>
        /// Obtiene o establece el número de vueltas restantes en la competencia.
        /// </summary>
        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { this.vueltasRestantes = (short)((value > 0) ? value : 0); }
        }

        // Sobrescritura de métodos

        /// <summary>
        /// Sobrescribe el método ToString para representar el vehículo como una cadena.
        /// </summary>
        /// <returns>Una cadena que representa el vehículo.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" *** Datos del vehículo ***");
            sb.AppendLine($"Escudería: {Escuderia}");
            sb.AppendLine($"Número: {Numero}");
            sb.AppendLine($"Cantidad de combustible: {CantidadCombustible}");
            if (EnCompetencia) sb.AppendLine($"Vueltas restantes: {VueltasRestantes}");
            else sb.AppendLine($"Fuera de competencia");

            return sb.ToString();
        }

        // Sobrecarga de operadores 

        // <summary>
        /// Compara dos vehículos de carrera para determinar si son iguales.
        /// </summary>
        /// <param name="vehiculo1">Primer vehículo a comparar.</param>
        /// <param name="vehiculo2">Segundo vehículo a comparar.</param>
        /// <returns>True si los vehículos son iguales, false en caso contrario.</returns>
        public static bool operator ==(VehiculoDeCarrera vehiculo1, VehiculoDeCarrera vehiculo2)
        {
            if (vehiculo1 is not null && vehiculo2 is not null)
            {
                return vehiculo1.Escuderia == vehiculo2.Escuderia && vehiculo1.Numero == vehiculo2.Numero;
            }
            return false;
        }

        /// <summary>
        /// Compara dos vehículos de carrera para determinar si son diferentes.
        /// </summary>
        /// <param name="vehiculo1">Primer vehículo a comparar.</param>
        /// <param name="vehiculo2">Segundo vehículo a comparar.</param>
        /// <returns>True si los vehículos son diferentes, false en caso contrario.</returns>
        public static bool operator !=(VehiculoDeCarrera vehiculo1, VehiculoDeCarrera vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }
    }
}
