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
        public static Cola<Expediente> EncolarTramitesRealizadosPor_EnMes_(Cola<Expediente> expedientes, string titular, int nroMes)
        {
            Cola<Expediente> colaNuevaExpedientes = new Cola<Expediente>();

            foreach (Expediente expediente in expedientes.Encolados)
            {
                if (expediente.Titular == titular && expediente.FechaDePresentacion.Month == nroMes)
                {
                    colaNuevaExpedientes.Encolar(expediente);
                }
            }
            return colaNuevaExpedientes;
        }
    }
}
