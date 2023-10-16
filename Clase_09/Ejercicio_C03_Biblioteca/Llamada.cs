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
    public abstract class Llamada
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
        /// Describe el costo de una llamada. 
        /// Observación: Propiedad abstracta de sólo lectura.
        /// </summary>
        public abstract float CostoLlamada { get; }

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

        #region Método Mostrar()

        /// <summary>
        /// Muestra los detalles de la llamada.
        /// </summary>
        /// <returns>Una cadena que representa los detalles de la llamada.</returns>
        protected virtual string Mostrar()
        {
            return $"Llamada[Duración: {Duracion}, Origen: {NroOrigen}, Destino: {NroDestino}]";
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Comprueba si dos llamadas son iguales comparando los números de origen y destino.
        /// </summary>
        /// <param name="llamada1">La primera llamada a comparar.</param>
        /// <param name="llamada2">La segunda llamada a comparar.</param>
        /// <returns>True si las llamadas son iguales, de lo contrario, False.</returns>
        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1 is not null && llamada2 is not null)
            {
                return llamada1.NroDestino == llamada2.NroDestino && llamada1.NroOrigen == llamada2.NroOrigen;
            }
            return false;
        }

        /// <summary>
        /// Comprueba si dos llamadas son diferentes comparando los números de origen y destino.
        /// </summary>
        /// <param name="llamada1">La primera llamada a comparar.</param>
        /// <param name="llamada2">La segunda llamada a comparar.</param>
        /// <returns>True si las llamadas son diferentes, de lo contrario, False.</returns>
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }

        #endregion
    }
}
