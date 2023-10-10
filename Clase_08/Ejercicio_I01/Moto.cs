using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    // <summary>
    /// La clase <see cref="Moto"/> representa un tipo específico de vehículo terrestre, en este caso, una motocicleta.
    /// Hereda de la clase <see cref="VehiculoTerrestre"/>.
    /// </summary>
    public class Moto : VehiculoTerrestre
    {
        // Atributos

        /// <summary>
        /// Campo privado que almacena la cilindrada de la motocicleta.
        /// </summary>
        private short cilindrada;

        // Constructor 🏍

        /// <summary>
        /// Constructor de la clase <see cref="Moto"/> que acepta el color y la cilindrada de la motocicleta.
        /// Establece la cantidad de ruedas en 2 y la cantidad de puertas en 0.
        /// </summary>
        /// <param name="color">El color de la motocicleta.</param>
        /// <param name="cilindrada">La cilindrada de la motocicleta.</param>
        public Moto(Color color, short cilindrada) : base(2, 0, color)
        {
            // Propósito: Inicializa una instancia de la clase Moto con información detallada sobre la motocicleta.
            // Precondiciones:
            // - La cilindrada debe ser un número positivo.

            this.cilindrada = cilindrada;
        }

        // Propiedades

        /// <summary>
        /// Propiedad pública para acceder y modificar la cilindrada de la motocicleta.
        /// </summary>
        public short Cilindrada
        {
            get { return cilindrada; }
            set
            {
                // Propósito: Establece la cilindrada de la motocicleta, asegurándose de que sea un número positivo.
                // Precondiciones: El valor debe ser un número positivo.
                if (value > 0) cilindrada = value;
            }
        }
    }
}
