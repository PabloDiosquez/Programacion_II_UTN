using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio_I02
{
    /// <summary>
    /// Clase sellada que representa un cuadrado, hereda de la clase Rectangulo y proporciona una implementación concreta para el método Dibujar.
    /// </summary>
    public sealed class Cuadrado : Rectangulo
    {
        // Atributo 

        private double lado;

        /// <summary>
        /// Constructor que crea un objeto Cuadrado con un lado específico.
        /// </summary>
        /// <param name="lado">La longitud de un lado del cuadrado.</param>
        public Cuadrado(double lado) : base(lado, lado)
        { }

        /// <summary>
        /// Sobrescribe el método Dibujar para proporcionar una representación textual personalizada de cómo se dibuja el cuadrado.
        /// </summary>
        /// <returns>Una cadena que representa la acción de dibujar un cuadrado.</returns>
        public new string Dibujar()
        {
            return "Dibujando un cuadrado...";
        }
    }
}
