using System;
using System.Text;

namespace EjercicioI01_Biblioteca
{
    /// <summary>
    /// Clase que representa un bolígrafo con la capacidad de escribir y recargar tinta.
    /// </summary>
    public class Boligrafo : IAcciones
    {
        // Atributos

        private ConsoleColor colorTinta;

        private float tinta;

        // Constructor 

        /// <summary>
        /// Inicializa una nueva instancia de la clase Boligrafo con la cantidad de unidades de tinta y el color especificados.
        /// </summary>
        /// <param name="unidades">La cantidad de unidades de tinta con la que se inicializa el bolígrafo.</param>
        /// <param name="color">El color de tinta con el que se inicializa el bolígrafo.</param>
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        // Propiedades 
        /// <summary>
        /// Obtiene o establece el color de tinta del bolígrafo.
        /// </summary>
        public ConsoleColor Color { get => colorTinta; set => colorTinta = value; }

        /// <summary>
        /// Obtiene o establece la cantidad de unidades de tinta disponible en el bolígrafo.
        /// </summary>
        public float UnidadesDeEscritura { get => tinta; set => tinta = value; }

        // Métodos de instancia

        /// <summary>
        /// Genera una representación de cadena que muestra información sobre el bolígrafo, incluyendo el color de la escritura y el nivel de tinta disponible.
        /// </summary>
        /// <returns>Una cadena que describe el bolígrafo.</returns>
        public override string ToString()
        {
            return $"Bolígrafo[Color: {this.Color}, Nivel de tinta: {this.UnidadesDeEscritura}]";
        }

        // Métodos de la interfaz

        /// <summary>
        /// Escribe un texto con el bolígrafo, utilizando la cantidad de tinta necesaria y actualizando el nivel de tinta.
        /// </summary>
        /// <param name="texto">El texto que se va a escribir.</param>
        /// <returns>Un objeto de tipo <see cref="EscrituraWrapper"/> que encapsula el texto y el color de escritura.</returns>
        public EscrituraWrapper Escribir(string texto)
        {
            float tintaUsada = 0.3F * texto.Replace(" ", "").Length;

            if (this.UnidadesDeEscritura - tintaUsada >= 0)
            {
                this.tinta -= tintaUsada;
            }
            else this.tinta = 0;

            return new EscrituraWrapper(texto, this.colorTinta);
        }

        /// <summary>
        /// Recarga el bolígrafo con la cantidad especificada de unidades de tinta.
        /// </summary>
        /// <param name="unidades">La cantidad de unidades de tinta a recargar.</param>
        /// <returns><c>true</c> si la recarga fue exitosa, <c>false</c> si falló.</returns>
        public bool Recargar(int unidades)
        {
            bool recargaRealizada = false;

            if (unidades >= 0)
            {
                this.tinta += unidades;
                recargaRealizada = true;
            }

            return recargaRealizada;
        }
    }
}
