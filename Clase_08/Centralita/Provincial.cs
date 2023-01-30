using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    internal class Provincial: Llamada
    {
        public enum franja 
        {
            Franja_1, 
            Franja_2, 
            Franja_3, 
        }

        protected franja franjaHoraria;

        public float CostoLlamada 
        {
            get { return CalcularCosto(); }
        }

        public Provincial(franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, franja miFranja, float duracion, string destino) : base(duracion, destino, origen) 
        {
            franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float costo;

            if (franjaHoraria == franja.Franja_1)
            {
                costo = 0.99F * duracion;
            }
            else if (franjaHoraria == franja.Franja_2)
            {
                costo = 1.25F * duracion;
            }
            else
            {
                costo = 0.66F * duracion;
            }

            return costo;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja: {}");
            sb.AppendLine($"Costo de la llamada: {CostoLlamada}");

            return sb.ToString();   
        }

    }
}
