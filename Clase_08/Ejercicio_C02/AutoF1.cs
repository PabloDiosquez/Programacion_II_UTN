using System;
using System.Text;

namespace Ejercicio_C02
{
    /// <summary>
    /// Clase que representa un auto de Fórmula 1.
    /// </summary>
    public class AutoF1
    {
        // Atributos 

        /// <summary>
        /// Cantidad de combustible del auto.
        /// </summary>
        private short cantidadCombustible;

        /// <summary>
        /// Indica si el auto está en competencia.
        /// </summary>
        private bool enCompetencia;

        /// <summary>
        /// Nombre de la escudería a la que pertenece el auto.
        /// </summary>
        private string escuderia;

        /// <summary>
        /// Número identificativo del auto.
        /// </summary>
        private short numero;

        /// <summary>
        /// Número de vueltas restantes en la competencia.
        /// </summary>
        private short vueltasRestantes;

        // Constructor 

        /// <summary>
        /// Constructor de la clase AutoF1.
        /// </summary>
        /// <param name="numero">Número identificativo del auto.</param>
        /// <param name="escuderia">Nombre de la escudería a la que pertenece el auto.</param>
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        // Getters y Setters 

        /// <summary>
        /// Obtiene o establece la cantidad de combustible del auto.
        /// </summary>
        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { if (cantidadCombustible > 0) this.cantidadCombustible = value; }
        }

        /// <summary>
        /// Obtiene el nombre de la escudería a la que pertenece el auto.
        /// </summary>
        public string Escuderia
        {
            get { return escuderia; }
        }

        /// <summary>
        /// Obtiene el número identificativo del auto.
        /// </summary>
        public short Numero
        {
            get { return numero; }
        }

        /// <summary>
        /// Obtiene o establece si el auto está en competencia.
        /// </summary>
        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { this.enCompetencia = value; }
        }

        /// <summary>
        /// Obtiene o establece el número de vueltas restantes en la competencia.
        /// </summary>
        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { if (value > 0) this.vueltasRestantes = value; }
        }

        // Métodos de instancia 

        /// <summary>
        /// Sobrescribe el método ToString para representar el auto como una cadena.
        /// </summary>
        /// <returns>Una cadena que representa el auto.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" *** Datos Auto *** ");
            sb.AppendLine($"Escudería: {Escuderia}");
            sb.AppendLine($"Número: {Numero}");
            sb.AppendLine($"Cantidad de combustible: {CantidadCombustible}");
            if (EnCompetencia) sb.AppendLine($"Vueltas restantes: {VueltasRestantes}");
            else sb.AppendLine($"Fuera de competencia");
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad (==) para comparar dos autos de Fórmula 1.
        /// </summary>
        /// <param name="auto1">Primer auto a comparar.</param>
        /// <param name="auto2">Segundo auto a comparar.</param>
        /// <returns>True si los autos son iguales, false en caso contrario.</returns>
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            if (auto1 is not null && auto2 is not null)
            {
                return auto1.numero == auto2.numero && auto1.escuderia == auto2.escuderia;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad (!=) para comparar dos autos de Fórmula 1.
        /// </summary>
        /// <param name="auto1">Primer auto a comparar.</param>
        /// <param name="auto2">Segundo auto a comparar.</param>
        /// <returns>True si los autos son diferentes, false en caso contrario.</returns>
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
    }
}
