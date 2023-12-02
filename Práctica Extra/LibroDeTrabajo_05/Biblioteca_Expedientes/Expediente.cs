using System;

namespace Biblioteca_Expedientes
{
    public class Expediente
    {
        private int numeroExpediente;

        private string titular;

        private string tramite;

        private DateTime fechaDePresentación;

        // Constructores

        public Expediente(int numeroExpediente, string titular) 
        {
            this.numeroExpediente = numeroExpediente;

            this.titular = titular;
        }

        public Expediente(int numeroExpediente, string titular, DateTime fechaDePresentacion)
            : this(numeroExpediente, titular)
        {
            this.fechaDePresentación = fechaDePresentacion;
        }

        // Propiedades 
        public int NumeroExpediente { get => numeroExpediente; }
        public string Titular { get => titular; set => titular = value; }
        public string Tramite { get => tramite; set => tramite = value; }
        public DateTime FechaDePresentación { get => fechaDePresentación; set => fechaDePresentación = value; }

        // Métodos de instancia

        public override string ToString()
        {
            return $"[Nro Expediente: {this.NumeroExpediente}, Titular: {this.Titular}, " +
                $"Trámite: {this.Tramite}, Fecha: {this.FechaDePresentación:D}]";
        }
    }
}
