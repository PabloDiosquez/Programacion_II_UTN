using System;

namespace Biblioteca_Ejercicio_I02
{
    /// <summary>
    /// Clase abstracta que define una figura geométrica.
    /// </summary>
    public abstract class Figura
    {
        /// <summary>
        /// Método que devuelve una representación textual de la acción de dibujar la figura.
        /// </summary>
        /// <returns>Una cadena que representa la acción de dibujar la figura.</returns>
        public string Dibujar()
        {
            return "Dibujando forma...";
        }

        /// <summary>
        /// Método abstracto para calcular la superficie de la figura.
        /// </summary>
        /// <returns>El valor de tipo double que representa la superficie de la figura.</returns>
        public abstract double CalcularSuperficie();

        /// <summary>
        /// Método abstracto para calcular el perímetro de la figura.
        /// </summary>
        /// <returns>El valor de tipo double que representa el perímetro de la figura.</returns>
        public abstract double CalcularPerimetro();
    }
}
