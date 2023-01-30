using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    internal class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) :
            this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        public float CostoLlamada 
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return costo * duracion;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {CostoLlamada}");

            return sb.ToString();
        }
        
    }
}
