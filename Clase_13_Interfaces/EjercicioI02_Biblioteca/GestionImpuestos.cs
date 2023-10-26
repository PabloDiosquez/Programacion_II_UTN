using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02_Biblioteca
{
    /// <summary>
    /// Clase que gestiona la información de impuestos aduaneros y de la AFIP.
    /// </summary>
    public class GestionImpuestos
    {
        // Atributos 

        /// <summary>
        /// Lista que almacena los impuestos relacionados con la aduana.
        /// </summary>
        private List<IAduana> impuestosAduana;

        /// <summary>
        /// Lista que almacena los impuestos relacionados con la AFIP (Administración Federal de Ingresos Públicos en Argentina).
        /// </summary>
        private List<IAfip> impuestosAfip;

        // Constructor 

        /// <summary>
        /// Constructor de la clase GestionImpuestos. Inicializa las listas de impuestos.
        /// </summary>
        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        // Métodos de instancia 

        /// <summary>
        /// Calcula el total de impuestos relacionados con la aduana.
        /// </summary>
        /// <returns>Total de impuestos aduaneros.</returns>
        /// <exception cref="NullReferenceException">Se lanza si la lista de impuestos de aduana es nula.</exception>
        public decimal CalcularTotalImpuestosAduana()
        {
            if (this.impuestosAduana is null) throw new NullReferenceException();

            decimal totalImpuestosAduana = 0;

            foreach (IAduana paqueteAduana in this.impuestosAduana)
            {
                totalImpuestosAduana += paqueteAduana.Impuestos;
            }
            return totalImpuestosAduana;
        }

        /// <summary>
        /// Calcula el total de impuestos relacionados con la AFIP.
        /// </summary>
        /// <returns>Total de impuestos de la AFIP.</returns>
        /// <exception cref="NullReferenceException">Se lanza si la lista de impuestos de la AFIP es nula.</exception>
        public decimal CalcularTotalImpuestosAfip()
        {
            if (this.impuestosAfip is null) throw new NullReferenceException();

            decimal totalImpuestosAfip = 0;

            foreach (IAfip paqueteAfip in this.impuestosAfip)
            {
                totalImpuestosAfip += paqueteAfip.Impuestos;
            }
            return totalImpuestosAfip;
        }

        /// <summary>
        /// Registra impuestos a partir de una colección de paquetes.
        /// </summary>
        /// <param name="paquetes">Colección de paquetes que se registrarán como impuestos.</param>
        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete paquete in paquetes)
            {
                this.impuestosAduana.Add(paquete);

                if (paquete is IAfip) this.impuestosAfip.Add(paquete as IAfip);
            }
        }

        /// <summary>
        /// Registra impuestos a partir de un paquete individual.
        /// </summary>
        /// <param name="paquete">Paquete que se registrará como impuesto.</param>
        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);

            if (paquete is IAfip) this.impuestosAfip.Add(paquete as IAfip);
        }
    }
}
