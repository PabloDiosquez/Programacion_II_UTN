using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C03_Centralita
{
    // Clase Local(hereda de Llamada)
public class Local : Llamada
    {
        // Atributos
        private float costo;  // Almacena el costo de la llamada local.

        // Constructores
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NumeroDestino, llamada.NumeroOrigen)
        {
            // Constructor que recibe una llamada base y un costo adicional.
            // Inicializa la instancia de Local con la duración, número de destino y número de origen de la llamada base.
            this.costo = costo;  // Inicializa el costo de la llamada local.
        }

        public Local(string origen, float duracion, string destino, float costo)
            : this(new Llamada(duracion, destino, origen), costo)
        {
            // Constructor que recibe el origen, duración, destino y costo, y crea una llamada base.
            // Luego, llama al constructor anterior para inicializar la instancia de Local.
        }

        // Método de instancia privado CalcularCosto
        private float CalcularCosto()
        {
            // Calcula el costo de la llamada local multiplicando la duración por el costo por minuto.
            return this.Duracion * this.CostoLlamada;
        }

        // Método de instancia Mostrar
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo llamada local: {this.CostoLlamada}");
            return sb.ToString();   
        }

        // Getter CostoLlamada
        public float CostoLlamada
        {
            get { return CalcularCosto(); }  // Devuelve el costo de la llamada local.
        }

        // Getter TipoLlamada
        public TipoLlamada TipoLlamada { get { return TipoLlamada.Local; } }

    }
}
