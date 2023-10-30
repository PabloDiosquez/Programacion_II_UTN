using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01_Biblioteca
{
    /// <summary>
    /// Clase que representa un vehículo de carrera.
    /// </summary>
    public class VehiculoDeCarrera
    {
        // Atributos 

        /// <summary>
        /// Cantidad de combustible del vehículo de carrera.
        /// </summary>
        private short cantidadCombustible;

        /// <summary>
        /// Indica si el vehículo de carrera está en competencia.
        /// </summary>
        private bool enCompetencia;

        /// <summary>
        /// Escudería a la que pertenece el vehículo de carrera.
        /// </summary>
        private string escuderia;

        /// <summary>
        /// Número de identificación del vehículo de carrera.
        /// </summary>
        private short numero;

        /// <summary>
        /// Cantidad de vueltas restantes del vehículo de carrera.
        /// </summary>
        private short vueltasRestantes;

        // Constructor 

        /// <summary>
        /// Constructor de la clase VehiculoDeCarrera que inicializa el número y la escudería del vehículo.
        /// </summary>
        /// <param name="numero">Número de identificación del vehículo.</param>
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
        /// Obtiene o establece la cantidad de combustible del vehículo de carrera.
        /// </summary>
        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }

        /// <summary>
        /// Obtiene o establece un valor que indica si el vehículo de carrera está en competencia.
        /// </summary>
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }

        /// <summary>
        /// Obtiene o establece el nombre de la escudería a la que pertenece el vehículo de carrera.
        /// </summary>
        public string Escuderia { get => escuderia; set => escuderia = value; }

        /// <summary>
        /// Obtiene o establece el número de identificación del vehículo de carrera.
        /// </summary>
        public short Numero { get => numero; set => numero = value; }

        /// <summary>
        /// Obtiene o establece la cantidad de vueltas restantes del vehículo de carrera.
        /// </summary>
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        // Métodos de instancia 

        /// <summary>
        /// Muestra los datos del vehículo de carrera, incluyendo número, escudería, cantidad de combustible y vueltas restantes.
        /// </summary>
        /// <returns>Una cadena que contiene los datos del vehículo de carrera.</returns>
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Datos del Vehículo de Carrera ***");
            sb.AppendLine($"Número: {this.Numero}");
            sb.AppendLine($"Escudería: {this.Escuderia}");
            if (this.EnCompetencia)
            {
                sb.AppendLine($"Vehículo en competencia.");
                sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");
                sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");
            }
            else
                sb.AppendLine("Vehículo fuera de competencia.");

            return sb.ToString();
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Compara si dos vehículos de carrera son iguales por número de identificación y escudería.
        /// </summary>
        /// <param name="vehiculo1">Primer vehículo de carrera a comparar.</param>
        /// <param name="vehiculo2">Segundo vehículo de carrera a comparar.</param>
        /// <returns>Verdadero si los vehículos son iguales, falso en caso contrario.</returns>
        public static bool operator ==(VehiculoDeCarrera vehiculo1, VehiculoDeCarrera vehiculo2)
        {
            if (vehiculo1 is null || vehiculo2 is null) return false;

            return vehiculo1.Numero == vehiculo2.Numero && vehiculo1.Escuderia == vehiculo2.Escuderia;
        }

        /// <summary>
        /// Compara si dos vehículos de carrera son diferentes por número de identificación o escudería.
        /// </summary>
        /// <param name="vehiculo1">Primer vehículo de carrera a comparar.</param>
        /// <param name="vehiculo2">Segundo vehículo de carrera a comparar.</param>
        /// <returns>Verdadero si los vehículos son diferentes, falso en caso contrario.</returns>
        public static bool operator !=(VehiculoDeCarrera vehiculo1, VehiculoDeCarrera vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }
    }
}
