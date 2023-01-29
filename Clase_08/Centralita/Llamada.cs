using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    internal class Llamada
    {
        public enum TipoLlamada
        {
            Local,

            Provincial,

            Todas,
        }

        protected float duracion;

        protected string nroDestino;

        protected string nroOrigen;

        public float Duracion
        {
            get { return duracion; }
        }

        public string NroDestino 
        {
            get { return nroDestino; }
        }

        public string NroOrigen 
        {
            get { return nroOrigen; }
        }

        public Llamada(float duaracion, string nroDestino, string nroOrigen) 
        {
            this.duracion = duaracion;

            this.nroDestino = nroDestino;

            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("### Datos de la llamada ###");
            sb.AppendLine($"Duración: {duracion}");
            sb.AppendLine($"Número de destino: {nroDestino}");
            sb.AppendLine($"Número de origen: {nroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int) (llamada1.duracion - llamada2.duracion);
        }
    }
}
