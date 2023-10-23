using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01_Biblioteca
{
    /// <summary>
    /// Clase que representa un lápiz con la capacidad de escribir y controlar el tamaño de la mina.
    /// </summary>
    public class Lapiz : IAcciones
    {
        // Atributos

        private float tamanioMina;

        // Constructor 

        /// <summary>
        /// Inicializa una nueva instancia de la clase Lapiz con el tamaño de mina especificado.
        /// </summary>
        /// <param name="unidades">El tamaño de la mina con el que se inicializa el lápiz.</param>
        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece la cantidad de unidades de escritura disponibles en el lápiz.
        /// </summary>
        float IAcciones.UnidadesDeEscritura { get => this.tamanioMina; set => throw new NotImplementedException(); }

        /// <summary>
        /// Obtiene o establece el color de escritura del lápiz (en este caso, es siempre gris).
        /// </summary>
        ConsoleColor IAcciones.Color { get => ConsoleColor.Gray; set => throw new NotImplementedException(); }

        // Métodos de instancia

        /// <summary>
        /// Genera una representación de cadena que muestra información sobre el lápiz, incluyendo el color de la escritura y el tamaño de la mina.
        /// </summary>
        /// <returns>Una cadena que describe el lápiz.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del lápiz");
            sb.AppendLine($"Color de la escritura: {((IAcciones)this).Color}");
            sb.AppendLine($"Tamaño de la mina: {((IAcciones)this).UnidadesDeEscritura}");

            return sb.ToString();
        }

        // Métodos de la interfaz

        /// <summary>
        /// Escribe un texto con el lápiz, utilizando el tamaño de mina y actualizando el tamaño de la mina.
        /// </summary>
        /// <param name="texto">El texto que se va a escribir.</param>
        /// <returns>Un objeto de tipo <see cref="EscrituraWrapper"/> que encapsula el texto y el color de escritura.</returns>
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            float totalMinaUsada = this.tamanioMina - 0.1F * texto.Replace(" ", "").Length;

            if (totalMinaUsada > 0) this.tamanioMina = totalMinaUsada;
            else tamanioMina = 0;

            return new EscrituraWrapper(texto, this.Color);
        }

        /// <summary>
        /// No se implementa en esta clase, ya que los lápices no admiten recarga.
        /// </summary>
        /// <param name="unidades">La cantidad de unidades a recargar (no se utiliza en los lápices).</param>
        /// <returns>Este método siempre lanza una excepción NotImplementedException.</returns>
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
