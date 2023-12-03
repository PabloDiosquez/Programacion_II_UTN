using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Colecciones;

namespace Biblioteca_Expedientes
{
    public static class HelpersExpedientes
    {
        /// <summary>
        /// Filtra y encola los trámites realizados por un titular en un mes específico.
        /// </summary>
        /// <param name="expedientes">Cola de expedientes original.</param>
        /// <param name="titular">Titular de los trámites a filtrar.</param>
        /// <param name="nroMes">Número del mes en el que se realizaron los trámites a filtrar.</param>
        /// <returns>
        /// Nueva cola que contiene solo los trámites realizados por el titular en el mes especificado.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Se lanza si la cola de expedientes original es nula.
        /// </exception>
        public static Cola<Expediente> EncolarTramitesRealizadosPorEnMes(
            Cola<Expediente> expedientes, string titular, int nroMes)
        {
            if (expedientes is null)
            {
                throw new ArgumentNullException(nameof(expedientes), "La cola de expedientes no puede ser nula.");
            }

            // Nueva cola para almacenar los trámites filtrados.
            Cola<Expediente> colaNuevaExpedientes = new Cola<Expediente>();

            // Iterar sobre los expedientes en la cola original.
            foreach (Expediente expediente in expedientes.Encolados)
            {
                // Verificar si el titular y el mes coinciden.
                if (expediente.Titular == titular && expediente.FechaDePresentacion?.Month == nroMes)
                {
                    // Encolar el expediente en la nueva cola.
                    colaNuevaExpedientes.Encolar(expediente);
                }
            }

            // Devolver la nueva cola con los trámites filtrados.
            return colaNuevaExpedientes;
        }
    }
}
