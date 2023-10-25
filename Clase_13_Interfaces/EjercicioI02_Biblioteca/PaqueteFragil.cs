using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02_Biblioteca
{
    /// <summary>
    /// Clase que representa un paquete frágil que hereda de la clase base Paquete.
    /// </summary>
    public class PaqueteFragil : Paquete
    {
        /// <summary>
        /// Obtiene un valor que indica si el paquete frágil tiene prioridad.
        /// Siempre devuelve true para los paquetes frágiles.
        /// </summary>
        public override bool TienePrioridad => true;

        /// <summary>
        /// Constructor de la clase PaqueteFragil.
        /// </summary>
        /// <param name="codigoSeguimiento">El código de seguimiento del paquete.</param>
        /// <param name="costoEnvio">El costo de envío del paquete.</param>
        /// <param name="destino">El destino del paquete.</param>
        /// <param name="origen">El origen del paquete.</param>
        /// <param name="pesoKg">El peso en kilogramos del paquete.</param>
        public PaqueteFragil(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        { }
    }
}
