using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    /// <summary>
    /// La clase <see cref="Automovil"/> representa un tipo específico de vehículo terrestre que es un automóvil.
    /// Hereda de la clase <see cref="VehiculoTerrestre"/>.
    /// </summary>
    public class Automovil : VehiculoTerrestre
    {
        // Atributos

        /// <summary>
        /// Campo privado que almacena la cantidad de marchas del automóvil.
        /// </summary>
        private short cantidadMarchas;

        /// <summary>
        /// Campo privado que almacena la cantidad de pasajeros que el automóvil puede transportar.
        /// </summary>
        private short cantidadPasajeros;

        // Constructor 👷🏼‍

        /// <summary>
        /// Constructor de la clase <see cref="Automovil"/> que acepta la cantidad de ruedas, la cantidad de puertas, el color, la cantidad de marchas y la cantidad de pasajeros del automóvil.
        /// </summary>
        /// <param name="cantidadRuedas">La cantidad de ruedas del automóvil.</param>
        /// <param name="cantidadPuertas">La cantidad de puertas del automóvil.</param>
        /// <param name="color">El color del automóvil.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del automóvil.</param>
        /// <param name="cantidadPasajeros">La cantidad de pasajeros que el automóvil puede transportar.</param>
        public Automovil(short cantidadRuedas, short cantidadPuertas, Color color, short cantidadMarchas, short cantidadPasajeros) :
            base(cantidadRuedas, cantidadPuertas, color)
        {
            // Propósito: Inicializa una instancia de la clase Automovil con información detallada sobre el vehículo.
            // Precondiciones:
            // - La cantidad de ruedas debe ser un número positivo.
            // - La cantidad de puertas debe ser un número positivo.
            // - La cantidad de marchas debe ser un número positivo.
            // - La cantidad de pasajeros debe ser un número positivo.
            // - El color debe ser válido.

            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    } 
}
