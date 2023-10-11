using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C03_Centralita
{
    // Enumeración Franja
    public enum Franja
    {
        Franja_1, // Representa la franja horaria 1.
        Franja_2, // Representa la franja horaria 2.
        Franja_3  // Representa la franja horaria 3.
    }

    // Clase Provincial (hereda de Llamada)
    public class Provincial : Llamada
    {
        // Atributos
        private Franja franjaHoraria; // Almacena la franja horaria de la llamada provincial.

        // Constructor
        public Provincial(Franja franjaHoraria, Llamada llamada)
            : base(llamada.Duracion, llamada.NumeroDestino, llamada.NumeroOrigen)
        {
            // Constructor que recibe una franja horaria y una llamada base.
            // Inicializa la instancia de Provincial con la duración, número de destino y número de origen de la llamada base.
            this.franjaHoraria = franjaHoraria; // Inicializa la franja horaria de la llamada provincial.
        }

        public Provincial(string origen, Franja franjaHoraria, float duracion, string destino)
            : this(franjaHoraria, new Llamada(duracion, destino, origen))
        {
            // Constructor que recibe el origen, franja horaria, duración, destino y crea una llamada base.
            // Luego, llama al constructor anterior para inicializar la instancia de Provincial.
        }

        // Propiedad CostoLlamada
        public float CostoLlamada
        {
            get { return CalcularCosto(); } // Devuelve el costo de la llamada provincial.
        }

        // Getter TipoLlamada

        public TipoLlamada TipoLlamada { get { return TipoLlamada.Provincial; } }

        // Método de instancia Mostrar (sobrescrito)
        public override string Mostrar()
        {
            // Crea una cadena de texto detallada con información sobre la llamada provincial, incluyendo la llamada base y la franja horaria.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja Horaria: {franjaHoraria.ToString()}");

            // Devuelve la cadena generada.
            return sb.ToString();
        }

        // Método privado CalcularCosto
        private float CalcularCosto()
        {
            // Define costos por minuto para cada franja horaria.
            const float costoFranja_1 = 0.99F;
            const float costoFranja_2 = 1.25F;
            const float costoFranja_3 = 0.66F;

            // Calcula el costo de la llamada provincial en función de la duración y la franja horaria.
            if (this.franjaHoraria == Franja.Franja_1)
            {
                return costoFranja_1 * this.Duracion;
            }
            else if (this.franjaHoraria == Franja.Franja_2)
            {
                return costoFranja_2 * this.Duracion;
            }
            // Si la franja horaria no es 1 ni 2, se asume la franja 3.
            return costoFranja_3 * this.Duracion;
        }
    }
}
