using System;

namespace Biblioteca_Expedientes
{
    /// <summary>
    /// Clase que representa un expediente con información como número de expediente, titular, trámite y fecha de presentación.
    /// </summary>
    public class Expediente
    {
        // Atributos

        private int numeroExpediente;
        private string titular;
        private string tramite;
        private DateTime fechaDePresentacion;

        // Constructores

        /// <summary>
        /// Constructor principal de la clase Expediente.
        /// </summary>
        /// <param name="numeroExpediente">Número de expediente.</param>
        /// <param name="titular">Titular del expediente.</param>
        public Expediente(int numeroExpediente, string titular)
        {
            this.numeroExpediente = numeroExpediente;
            this.titular = titular;
        }

        /// <summary>
        /// Constructor secundario de la clase Expediente que incluye la fecha de presentación.
        /// </summary>
        /// <param name="numeroExpediente">Número de expediente.</param>
        /// <param name="titular">Titular del expediente.</param>
        /// <param name="fechaDePresentacion">Fecha de presentación del expediente.</param>
        public Expediente(int numeroExpediente, string titular, DateTime fechaDePresentacion)
            : this(numeroExpediente, titular)
        {
            this.fechaDePresentacion = fechaDePresentacion;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene el número de expediente.
        /// </summary>
        public int NumeroExpediente { get => numeroExpediente; }

        /// <summary>
        /// Obtiene o establece el titular del expediente.
        /// </summary>
        public string Titular { get => titular; set => titular = value; }

        /// <summary>
        /// Obtiene o establece el trámite del expediente.
        /// </summary>
        public string Tramite { get => tramite; set => tramite = value; }

        /// <summary>
        /// Obtiene o establece la fecha de presentación del expediente.
        /// </summary>
        public DateTime FechaDePresentacion { get => fechaDePresentacion; set => fechaDePresentacion = value; }

        // Métodos de instancia

        /// <summary>
        /// Devuelve una representación en cadena de los datos del expediente.
        /// </summary>
        /// <returns>Cadena que representa los datos del expediente.</returns>
        public override string ToString()
        {
            return $"[Nro Expediente: {this.NumeroExpediente}, Titular: {this.Titular}, " +
                $"Trámite: {this.Tramite}, Fecha: {this.FechaDePresentacion:D}]";
        }
    }
}
