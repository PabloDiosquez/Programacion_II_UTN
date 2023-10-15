using System;
using System.Text;

namespace Ejercicio_C03_Biblioteca
{
    /// <summary>
    /// Enumeración que representa los tipos de llamadas posibles.
    /// </summary>
    public enum TipoLlamada
    {
        /// <summary>
        /// Llamada local.
        /// </summary>
        Local,

        /// <summary>
        /// Llamada provincial.
        /// </summary>
        Provincial,

        /// <summary>
        /// Todos los tipos de llamadas.
        /// </summary>
        Todas,
    }

    /// <summary>
    /// Clase que representa una llamada telefónica.
    /// </summary>
    public class Llamada
    {
        #region Atributos

        // Atributos privados de la clase.

        private float duracion;
        private string nroDestino;
        private string nroOrigen;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor de la clase <see cref="Llamada"/>.
        /// </summary>
        /// <param name="duracion">Duración de la llamada en minutos.</param>
        /// <param name="nroDestino">Número de destino de la llamada.</param>
        /// <param name="nroOrigen">Número de origen de la llamada.</param>
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion

        #region Propiedades (sólo lectura)

        /// <summary>
        /// Obtiene la duración de la llamada en minutos.
        /// </summary>
        public float Duracion
        {
            get { return duracion; }
        }

        /// <summary>
        /// Obtiene el número de destino de la llamada.
        /// </summary>
        public string NroDestino
        {
            get { return nroDestino; }
        }

        /// <summary>
        /// Obtiene el número de origen de la llamada.
        /// </summary>
        public string NroOrigen
        {
            get { return nroOrigen; }
        }

        #endregion

        #region Sobrescritura del método ToString()

        /// <summary>
        /// Devuelve una representación en forma de cadena de la llamada.
        /// </summary>
        /// <returns>Una cadena que contiene los datos de la llamada.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" *** Datos de la llamada *** ");
            sb.AppendLine($"Duración: {Duracion} minutos");
            sb.AppendLine($"Número de destino: {NroDestino}");
            sb.AppendLine($"Número de origen: {NroOrigen}");

            return sb.ToString();
        }

        #endregion

        #region Comparación entre llamadas

        /// <summary>
        /// Compara dos llamadas basándose en su duración.
        /// </summary>
        /// <param name="llamada1">Primera llamada a comparar.</param>
        /// <param name="llamada2">Segunda llamada a comparar.</param>
        /// <returns>Un valor entero negativo si la primera llamada es menor en duración, 
        /// cero si son iguales y un valor entero positivo si la primera llamada es mayor en duración.</returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return Convert.ToInt32(llamada1.Duracion - llamada2.Duracion);
        }

        #endregion
    }
}
