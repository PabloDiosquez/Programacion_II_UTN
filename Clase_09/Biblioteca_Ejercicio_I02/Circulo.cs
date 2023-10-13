using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio_I02
{
    /// <summary>
    /// Clase que representa un círculo, hereda de la clase Figura y 
    /// proporciona implementaciones concretas para los métodos abstractos.
    /// Esta clase está sellada.
    /// </summary>
    public sealed class Circulo : Figura
    {
        // Atributos

        private double radio;

        /// <summary>
        /// Constructor que crea un objeto Circulo con un radio específico.
        /// </summary>
        /// <param name="radio">El radio del círculo.</param>
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Implementación de los métodos abstractos de la clase base.

        /// <summary>
        /// Calcula la superficie del círculo.
        /// </summary>
        /// <returns>El área del círculo como un valor de tipo double.</returns>
        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }

        /// <summary>
        /// Calcula el perímetro del círculo.
        /// </summary>
        /// <returns>El perímetro del círculo como un valor de tipo double.</returns>
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.radio;
        }

        /// <summary>
        /// Sobrescribe el método Dibujar para proporcionar una representación textual personalizada de cómo se dibuja el círculo.
        /// </summary>
        /// <returns>Una cadena que representa la acción de dibujar un círculo.</returns>
        public new string Dibujar()
        {
            return "Dibujando un círculo...";
        }
    }
}
