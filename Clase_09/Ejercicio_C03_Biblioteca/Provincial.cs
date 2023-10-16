using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C03_Biblioteca
{
    /// <summary>
    /// Enumeración que representa las franjas horarias posibles para llamadas provinciales.
    /// </summary>
    public enum Franja
    {
        /// <summary>
        /// Franja horaria 1.
        /// </summary>
        Franja_1,

        /// <summary>
        /// Franja horaria 2.
        /// </summary>
        Franja_2,

        /// <summary>
        /// Franja horaria 3.
        /// </summary>
        Franja_3,
    }

    /// <summary>
    /// Clase que representa una llamada telefónica de tipo provincial.
    /// </summary>
    public class Provincial : Llamada
    {
        #region Atributos

        // Atributo privado de la clase.

        private Franja franjaHoraria;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase <see cref="Provincial"/>.
        /// </summary>
        /// <param name="origen">Número de origen de la llamada.</param>
        /// <param name="franjaHoraria">Franja horaria de la llamada provincial.</param>
        /// <param name="duracion">Duración de la llamada en minutos.</param>
        /// <param name="destino">Número de destino de la llamada.</param>
        public Provincial(string origen, Franja franjaHoraria, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        /// <summary>
        /// Constructor de la clase <see cref="Provincial"/> que crea una llamada provincial a partir de una llamada base y una franja horaria.
        /// </summary>
        /// <param name="franjaHoraria">Franja horaria de la llamada provincial.</param>
        /// <param name="llamada">Llamada base de la cual se obtienen los datos.</param>
        public Provincial(Franja franjaHoraria, Llamada llamada)
            : this(llamada.NroOrigen, franjaHoraria, llamada.Duracion, llamada.NroDestino) { }

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene la franja horaria de la llamada provincial.
        /// </summary>
        public Franja FranjaHoraria { get; }

        /// <summary>
        /// Obtiene el costo total de la llamada provincial.
        /// </summary>
        public override float CostoLlamada => CalcularCosto();

        #endregion

        #region Sobrescritura del método ToString()

        /// <summary>
        /// Devuelve una representación en forma de cadena de la llamada provincial.
        /// </summary>
        /// <returns>Una cadena que contiene los datos de la llamada provincial y su costo.</returns>
        public override string ToString()
        {
            return Mostrar();
        }

        #endregion

        #region Métodos de instancia

        /// <summary>
        /// Calcula el costo total de la llamada provincial basado en la franja horaria.
        /// </summary>
        /// <returns>El costo total de la llamada provincial.</returns>
        private float CalcularCosto()
        {
            const float COSTO_FRANJA1 = 0.99F;
            const float COSTO_FRANJA2 = 1.25F;
            const float COSTO_FRANJA3 = 0.66F;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return COSTO_FRANJA1 * this.Duracion;

                case Franja.Franja_2:
                    return COSTO_FRANJA2 * this.Duracion;

                case Franja.Franja_3:
                    return COSTO_FRANJA3 * this.Duracion;

                default:
                    return -1; // En caso de franja horaria no válida.
            }
        }

        /// <summary>
        /// Devuelve una representación detallada de la llamada provincial, incluyendo la franja horaria y el costo.
        /// </summary>
        /// <returns>Una cadena que representa los detalles de la llamada provincial.</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja horaria: {FranjaHoraria}");
            sb.AppendLine($"Costo de la llamada: {CostoLlamada}");

            return sb.ToString();
        }

        /// <summary>
        /// Determina si el objeto especificado es igual a esta instancia de llamada provincial.
        /// </summary>
        /// <param name="objeto">El objeto a comparar con esta instancia.</param>
        /// <returns>True si el objeto es una instancia de llamada provincial, de lo contrario, False.</returns>
        public override bool Equals(object objeto)
        {
            return objeto is Provincial;
        }
    }
}
