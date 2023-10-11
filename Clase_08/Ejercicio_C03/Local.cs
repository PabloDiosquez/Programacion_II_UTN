using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C03_Centralita
{
    public class Local : Llamada
    {
        // Atributos

        private float costo;

        // Constructor 

        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NumeroDestino, llamada.NumeroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : this(new Llamada(duracion, destino, origen), costo)
        {

        }

        public float CostoLlamada { get; }

        // Método de instancia 

        private float CalcularCosto() 
        {

        }
    }
}
