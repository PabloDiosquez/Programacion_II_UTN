using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C03_Biblioteca
{
    /// <summary>
    /// Clase que representa una llamada telefónica de tipo local.
    /// </summary>
    public class Local : Llamada
    {
        #region Atributos

        // Atributo privado de la clase.

        private float costo;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase <see cref="Local"/>.
        /// </summary>
        /// <param name="nroOrigen">Número de origen de la llamada.</param>
        /// <param name="duracion">Duración de la llamada en minutos.</param>
        /// <param name="nroDestino">Número de destino de la llamada.</param>
        /// <param name="costo">Costo por minuto de la llamada local.</param>
        public Local(string nroOrigen, float duracion, string nroDestino, float costo)
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        /// <summary>
        /// Constructor de la clase <see cref="Local"/> que crea una llamada local a partir de una llamada base y un costo.
        /// </summary>
        /// <param name="llamada">Llamada base de la cual se obtienen los datos.</param>
        /// <param name="costo">Costo por minuto de la llamada local.</param>
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo) { }

        #endregion

        #region Propiedades (sólo lectura)

        /// <summary>
        /// Obtiene el costo total de la llamada local.
        /// </summary>
        public override float CostoLlamada => CalcularCosto();

        #endregion

        #region Sobrescritura del método ToString()

        /// <summary>
        /// Devuelve una representación en forma de cadena de la llamada local usando el método Mostrar().
        /// </summary>
        /// <returns>Una cadena que contiene los datos de la llamada local y su costo.</returns>
        public override string ToString()
        {
            return Mostrar();
        }

        #endregion

        #region Métodos de instancia

        /// <summary>
        /// Calcula el costo total de la llamada local.
        /// </summary>
        /// <returns>El costo total de la llamada local.</returns>
        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }

        /// <summary>
        /// Devuelve una representación detallada de la llamada local, incluyendo el costo.
        /// </summary>
        /// <returns>Una cadena que representa los detalles de la llamada local.</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {CostoLlamada}");

            return sb.ToString();
        }

        /// <summary>
        /// Determina si el objeto especificado es igual a esta instancia de llamada local.
        /// </summary>
        /// <param name="objeto">El objeto a comparar con esta instancia.</param>
        /// <returns>True si el objeto es una instancia de llamada local, de lo contrario, False.</returns>
        public override bool Equals(Object objeto)
        {
            return objeto is Local;
        }

        public static explicit operator Local(bool v)
        {
            return null;
        }
        #endregion
    }
}
