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

        public Local(Llamada llamada, float costo) : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo)
        {

        }

        public Local(float duracion, string nroDestino, string nroOrigen, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        private float CostoLlamada 
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return costo * duracion;
        }
    }
}
