using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio_I02
{
    /// <summary>
    /// Clase que representa un rectángulo, hereda de la clase Figura y proporciona implementaciones concretas para los métodos abstractos.
    /// </summary>
    public class Rectangulo : Figura
    {
        // Atributos

        protected double alto;
        protected double ancho;

        /// <summary>
        /// Constructor que crea un objeto Rectangulo con las dimensiones especificadas.
        /// </summary>
        /// <param name="alto">La altura del rectángulo.</param>
        /// <param name="ancho">El ancho del rectángulo.</param>
        public Rectangulo(double alto, double ancho)
        {
            this.alto = alto;
            this.ancho = ancho;
        }

        // Implementación de los métodos abstractos de la clase base.

        /// <summary>
        /// Calcula la superficie del rectángulo.
        /// </summary>
        /// <returns>El área del rectángulo como un valor de tipo double.</returns>
        public override double CalcularSuperficie()
        {
            return this.alto * this.ancho;
        }

        /// <summary>
        /// Calcula el perímetro del rectángulo.
        /// </summary>
        /// <returns>El perímetro del rectángulo como un valor de tipo double.</returns>
        public override double CalcularPerimetro()
        {
            return 2 * (this.alto + this.ancho);
        }

        /// <summary>
        /// Sobrescribe el método Dibujar para proporcionar una representación textual personalizada de cómo se dibuja el rectángulo.
        /// </summary>
        /// <returns>Una cadena que representa la acción de dibujar un rectángulo.</returns>
        public new string Dibujar()
        {
            return "Dibujando un rectángulo...";
        }
    }
}
