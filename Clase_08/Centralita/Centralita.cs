using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    internal class Centralita
    {
        protected List<Llamada> listaLlamadas;

        protected string razonSocial;

        public Centralita()
        {
            listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        public float GananciaPorLocal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciaPorTodas 
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas 
        {
            get { return listaLlamadas; }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0F;

            if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
            {
                foreach (Llamada llamada in listaLlamadas)
                {
                    if (llamada is Local local)
                    {
                        ganancia += local.CostoLlamada;
                    }
                }
            }
            else if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
            {
                foreach (Llamada llamada in listaLlamadas)
                {
                    if (llamada is Provincial provincial) 
                    {
                        ganancia += provincial.CostoLlamada;
                    }
                }            
            }

            return ganancia;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Centralita: {razonSocial}");
            sb.AppendLine("Lista de llamadas:");

            foreach (Llamada llamada in listaLlamadas)
            {
                if (llamada is Local llamadaLocal)
                {
                    sb.AppendLine(llamadaLocal.Mostrar());
                }
                else if (llamada is Provincial llamadaProvincial) 
                {
                    sb.AppendLine(llamadaProvincial.Mostrar());
                }
            }

            return sb.ToString();   
        }

        public void OrdenarLlamadas()
        {
            listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
