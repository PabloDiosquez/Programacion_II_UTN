using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C03_Centralita
{
    /// <summary>
    /// Representa una centralita telefónica que registra y gestiona llamadas.
    /// </summary>
    public class Centralita
    {
        // Campos

        private List<Llamada> llamadas;  // Lista que almacena las llamadas registradas.
        private string razonSocial;      // Nombre de la centralita.

        /// <summary>
        /// Constructor privado de la centralita para inicializar la lista de llamadas.
        /// </summary>
        private Centralita()
        {
            llamadas = new List<Llamada>();
        }

        /// <summary>
        /// Constructor público de la centralita que recibe la razón social y llama al constructor privado.
        /// </summary>
        /// <param name="razonSocial">El nombre de la centralita.</param>
        public Centralita(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        // Propiedades

        /// <summary>
        /// Obtiene o establece la razón social de la centralita.
        /// Si el valor es nulo o cadena vacía, se establece como cadena vacía.
        /// </summary>
        public string RazonSocial
        {
            get { return razonSocial; }
            set
            {
                if (!string.IsNullOrEmpty(value)) this.razonSocial = value;
                else this.razonSocial = string.Empty;
            }
        }

        /// <summary>
        /// Obtiene la lista de llamadas registradas en la centralita.
        /// </summary>
        public List<Llamada> Llamadas
        {
            get { return llamadas; }
        }

        /// <summary>
        /// Obtiene las ganancias totales por llamadas locales.
        /// </summary>
        public float GananciasPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }

        /// <summary>
        /// Obtiene las ganancias totales por llamadas provinciales.
        /// </summary>
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }

        /// <summary>
        /// Obtiene las ganancias totales por todas las llamadas.
        /// </summary>
        public float GananciasPorTodas
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }

        // Métodos de instancia

        /// <summary>
        /// Calcula la ganancia total según el tipo de llamada (Local, Provincial o Todas).
        /// </summary>
        /// <param name="tipo">El tipo de llamada para calcular las ganancias.</param>
        /// <returns>La ganancia total para el tipo de llamada especificado.</returns>
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float totalRecaudado = 0;

            if (tipo == TipoLlamada.Local)
            {
                foreach (Llamada llamada in this.Llamadas)
                {
                    if (llamada.TipoLlamada == TipoLlamada.Local)
                        totalRecaudado += ((Local)llamada).CostoLlamada;
                }
            }
            else if (tipo == TipoLlamada.Provincial)
            {
                foreach (Llamada llamada in this.Llamadas)
                {
                    if (llamada.TipoLlamada == TipoLlamada.Provincial)
                        totalRecaudado += ((Provincial)llamada).CostoLlamada;
                }
            }
            return totalRecaudado;
        }

        /// <summary>
        /// Genera una representación en forma de cadena de texto de la información de la centralita,
        /// incluyendo la razón social y detalles de todas las llamadas registradas.
        /// </summary>
        /// <returns>Una cadena que representa la información de la centralita.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" *** Datos Centralita *** ");
            sb.AppendLine($"Razón Social: {razonSocial}");
            sb.AppendLine("Datos de las llamadas:");
            foreach (Llamada llamada in this.Llamadas)
            {
                sb.AppendLine(llamada.Mostrar());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Ordena las llamadas en la lista de llamadas de la centralita por duración.
        /// </summary>
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
