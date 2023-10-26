using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02_Biblioteca
{
    /// <summary>
    /// Clase que representa un paquete pesado que hereda de la clase base Paquete.
    /// </summary>
    public class PaquetePesado : Paquete, IAduana, IAfip
    {
        /// <summary>
        /// Obtiene un valor que indica si el paquete pesado tiene prioridad.
        /// Siempre devuelve false para los paquetes pesados.
        /// </summary>
        public override bool TienePrioridad => false;

        /// <summary>
        /// Constructor de la clase PaquetePesado.
        /// </summary>
        /// <param name="codigoSeguimiento">El código de seguimiento del paquete.</param>
        /// <param name="costoEnvio">El costo de envío del paquete.</param>
        /// <param name="destino">El destino del paquete.</param>
        /// <param name="origen">El origen del paquete.</param>
        /// <param name="pesoKg">El peso en kilogramos del paquete.</param>
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        { }

        // Propiedades y Métodos de interfaces 

        // <summary>
        /// Obtiene el monto de impuestos según la interfaz IAduana.
        /// Calculado como el 25% del costo de envío.
        /// </summary>
        decimal IAduana.Impuestos => (decimal)0.35 * this.costoEnvio;

        /// <summary>
        /// Obtiene el monto de impuestos según la interfaz IAfip.
        /// Calculado como el 25% del costo de envío.
        /// </summary>
        decimal IAfip.Impuestos => (decimal)0.25 * this.costoEnvio;

        /// <summary>
        /// Calcula y devuelve el costo total incluyendo impuestos de ambas interfaces.
        /// </summary>
        /// <returns>El costo total con impuestos.</returns>
        public override decimal AplicarImpuestos()
        {
            // Se realiza una conversión explícita a IAfip para acceder a Impuestos de IAfip.
            return this.costoEnvio + ((IAfip)this).Impuestos + ((IAduana)this).Impuestos;
        }
    }
}
