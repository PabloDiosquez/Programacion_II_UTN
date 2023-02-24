using System;
using System.Text;

namespace Biblioteca_Aduana
{
    public abstract class Paquete
    {
        private string codigoSeguimiento;

        protected decimal costoEnvio;

        private string destino;

        private string origen;

        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;

            this.costoEnvio = costoEnvio;

            this.destino = destino;

            this.origen = origen;

            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get; }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"### Datos del paquete ###");
            sb.AppendLine($"Código de seguimiento: {codigoSeguimiento}");
            sb.AppendLine($"Origen: {origen}");
            sb.AppendLine($"Destino: {destino}");
            sb.AppendLine($"Costo envío: {costoEnvio}");
            sb.AppendLine($"Peso (en kg): {pesoKg}");

            return sb.ToString();   
        }

    }
}
