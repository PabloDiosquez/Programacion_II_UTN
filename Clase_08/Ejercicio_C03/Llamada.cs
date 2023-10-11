using System;
using System.Text;

namespace Ejercicio_C03
{
    // Enumeración TipoLlamada
    public enum TipoLlamada
    {
        Local,      // Representa una llamada local.
        Provincial, // Representa una llamada provincial.
        Todas       // Representa todos los tipos de llamadas.
    }

    // Clase Llamada
    public class Llamada
    {
        // Atributos
        protected float duracion;         // Almacena la duración de la llamada.
        protected string numeroDestino;   // Almacena el número de destino de la llamada.
        protected string numeroOrigen;    // Almacena el número de origen de la llamada.

        // Constructor
        public Llamada(float duracion, string numeroDestino, string numeroOrigen)
        {
            // Inicializa los atributos de la llamada con los valores proporcionados.
            this.duracion = duracion;
            this.numeroDestino = numeroDestino;
            this.numeroOrigen = numeroOrigen;
        }

        // Propiedades (getters)
        public float Duracion
        {
            get { return duracion; }        // Devuelve la duración de la llamada.
        }

        public string NumeroDestino
        {
            get { return numeroDestino; }  // Devuelve el número de destino de la llamada.
        }

        public string NumeroOrigen
        {
            get { return numeroOrigen; }   // Devuelve el número de origen de la llamada.
        }

        // Método de instancia Mostrar
        public string Mostrar()
        {
            // Crea una cadena de texto detallada con información sobre la llamada.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Datos de la llamada ***");
            sb.AppendLine($"Duración: {Duracion}");
            sb.AppendLine($"Número de destino: {NumeroDestino}");
            sb.AppendLine($"Número de origen: {NumeroOrigen}");

            // Devuelve la cadena generada.
            return sb.ToString();
        }

        // Método de clase OrdenarPorDuracion
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion == llamada2.Duracion)
                return 0;   // Las duraciones son iguales.
            else if (llamada1.Duracion > llamada2.Duracion)
                return 1;   // La duración de la primera llamada es mayor.
            else
                return -1;  // La duración de la segunda llamada es mayor.
        }
    }
}
