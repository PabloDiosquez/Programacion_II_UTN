using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C03_Biblioteca
{
    /// <summary>
    /// Clase que representa una centralita telefónica que administra llamadas locales y provinciales.
    /// </summary>
    public class Centralita
    {
        #region Atributos

        // Atributos privados de la clase.

        private string razonSocial;
        private List<Llamada> llamadas;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor privado de la clase <see cref="Centralita"/>.
        /// </summary>
        private Centralita()
        {
            llamadas = new List<Llamada>();
        }

        /// <summary>
        /// Constructor de la clase <see cref="Centralita"/>.
        /// </summary>
        /// <param name="razonSocial">Nombre o razón social de la centralita.</param>
        public Centralita(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene las ganancias generadas por llamadas locales.
        /// </summary>
        public float GananciasPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }

        /// <summary>
        /// Obtiene las ganancias generadas por llamadas provinciales.
        /// </summary>
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }

        /// <summary>
        /// Obtiene las ganancias generadas por todas las llamadas (locales y provinciales).
        /// </summary>
        public float GananciasPorTodas
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }

        /// <summary>
        /// Obtiene la lista de llamadas registradas en la centralita.
        /// </summary>
        public List<Llamada> Llamadas
        {
            get { return llamadas; }
        }

        #endregion

        #region Métodos de instancia

        /// <summary>
        /// Calcula las ganancias generadas por un tipo específico de llamada.
        /// </summary>
        /// <param name="tipo">El tipo de llamada para el cual se desea calcular las ganancias.</param>
        /// <returns>Las ganancias generadas por el tipo de llamada especificado.</returns>
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (Llamada llamada in Llamadas)
            {
                if (llamada is Local local)
                {
                    gananciaLocal += local.CostoLlamada;
                }

                if (llamada is Provincial provincial)
                {
                    gananciaProvincial += provincial.CostoLlamada;
                }
            }

            switch (tipo)
            {
                case TipoLlamada.Local:
                    return gananciaLocal;
                case TipoLlamada.Provincial:
                    return gananciaProvincial;
                default:
                    return gananciaLocal + gananciaProvincial;
            }
        }

        /// <summary>
        /// Ordena la lista de llamadas en la centralita por duración.
        /// </summary>
        public void OrdenarLlamadas()
        {
            this.llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion

        #region Sobrescritura del método ToString()

        /// <summary>
        /// Devuelve una representación en forma de cadena de la centralita, incluyendo las ganancias y detalles de las llamadas.
        /// </summary>
        /// <returns>Una cadena que contiene los datos de la centralita y sus llamadas.</returns>
        public override string ToString()
        {
            return Mostrar();
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" *** Datos de la Centralita *** ");
            sb.AppendLine($"Razón Social: {razonSocial}");
            sb.AppendLine($"Ganancias por llamadas locales: {GananciasPorLocal}");
            sb.AppendLine($"Ganancias por llamadas provinciales: {GananciasPorProvincial}");
            sb.AppendLine($"Ganancias en total: {GananciasPorTodas}");
            sb.AppendLine("\nDetalle de las llamadas:");
            foreach (Llamada llamada in Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }


        #endregion
    }
}
