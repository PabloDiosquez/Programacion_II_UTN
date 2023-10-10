using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    /// <summary>
    /// La clase <see cref="Camion"/> representa un tipo específico de vehículo terrestre, en este caso, un camión.
    /// Hereda de la clase <see cref="VehiculoTerrestre"/>.
    /// </summary>
    public class Camion : VehiculoTerrestre
    {
        // Atributos

        /// <summary>
        /// Campo privado que almacena la cantidad de marchas del camión.
        /// </summary>
        private short cantidadMarchas;

        /// <summary>
        /// Campo privado que almacena el peso de carga máximo que el camión puede transportar.
        /// </summary>
        private float pesoCarga;

        // Constructor 🚒

        /// <summary>
        /// Constructor de la clase <see cref="Camion"/> que acepta la cantidad de ruedas, la cantidad de puertas, el color, la cantidad de marchas y el peso de carga del camión.
        /// </summary>
        /// <param name="cantidadRuedas">La cantidad de ruedas del camión.</param>
        /// <param name="cantidadPuertas">La cantidad de puertas del camión.</param>
        /// <param name="color">El color del camión.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del camión.</param>
        /// <param name="pesoCarga">El peso de carga máximo que el camión puede transportar.</param>
        public Camion(short cantidadRuedas, short cantidadPuertas, Color color, short cantidadMarchas, float pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            // Propósito: Inicializa una instancia de la clase Camion con información detallada sobre el vehículo.
            // Precondiciones:
            // - La cantidad de ruedas debe ser un número positivo.
            // - La cantidad de puertas debe ser un número positivo.
            // - La cantidad de marchas debe ser un número positivo.
            // - El peso de carga debe ser un número positivo o cero (representa la capacidad máxima de carga del camión).
            // - El color debe ser válido (se recomienda utilizar la enumeración System.Drawing.Color).

            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        // Propiedades

        /// <summary>
        /// Propiedad pública para acceder y modificar la cantidad de marchas del camión.
        /// </summary>
        public short CantidadMarchas
        {
            get { return cantidadMarchas; }
            set
            {
                // Propósito: Establece la cantidad de marchas del camión, asegurándose de que sea un número positivo.
                // Precondiciones: El valor debe ser un número positivo.
                if (value > 0) cantidadMarchas = value;
            }
        }

        /// <summary>
        /// Propiedad pública para acceder y modificar el peso de carga máximo que el camión puede transportar.
        /// </summary>
        public float PesoCarga
        {
            get { return pesoCarga; }
            set
            {
                // Propósito: Establece el peso de carga máximo que el camión puede transportar, asegurándose de que sea un número positivo o cero.
                // Precondiciones: El valor debe ser un número positivo o cero.
                if (value > 0) pesoCarga = value;
            }
        }
    }
}
