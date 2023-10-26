using System;
using System.Text;

namespace EjercicioI02_Biblioteca
{
    /// <summary>
    /// Clase abstracta que representa un paquete de envío.
    /// </summary>
    public abstract class Paquete : IAduana
    {
        // Atributos 

        /// <summary>
        /// Código de seguimiento único del paquete.
        /// </summary>
        private string codigoSeguimiento;

        /// <summary>
        /// Costo de envío del paquete.
        /// </summary>
        protected decimal costoEnvio;

        /// <summary>
        /// Destino al que se envía el paquete.
        /// </summary>
        private string destino;

        /// <summary>
        /// Origen desde donde se envía el paquete.
        /// </summary>
        private string origen;

        /// <summary>
        /// Peso del paquete en kilogramos.
        /// </summary>
        private double pesoKg;

        // Constructor 
        /// <summary>
        /// Constructor de la clase Paquete.
        /// </summary>
        /// <param name="codigoSeguimiento">Código de seguimiento del paquete.</param>
        /// <param name="costoEnvio">Costo de envío del paquete.</param>
        /// <param name="destino">Destino del paquete.</param>
        /// <param name="origen">Origen del paquete.</param>
        /// <param name="pesoKg">Peso del paquete en kilogramos.</param>
        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        // Properties 
        /// <summary>
        /// Indica si el paquete tiene prioridad.
        /// </summary>
        public abstract bool TienePrioridad { get; }

        // Métodos de instancia 
        /// <summary>
        /// Obtiene información detallada del paquete.
        /// </summary>
        /// <returns>Información del paquete en formato de cadena.</returns>
        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Información del paquete:");
            sb.AppendLine($"Código de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envío: {this.costoEnvio}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Peso (en kilogramos): {this.pesoKg}");

            return sb.ToString();
        }

        // Propiedades y métodos de la interfaz

        /// <summary>
        /// Obtiene el monto de impuestos aplicado a un elemento.
        /// Calculado como el 35% del costo de envío.
        /// </summary>
        public decimal Impuestos => (decimal)0.35 * this.costoEnvio;

        /// <summary>
        /// Calcula y devuelve el costo total incluyendo impuestos.
        /// </summary>
        /// <returns>El costo total con impuestos.</returns>
        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos;    
        }
    }
}
