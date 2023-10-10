using System;


namespace Ejercicio_I01
{
    /// <summary>
    /// La clase <see cref="VehiculoTerrestre"/> representa un vehículo que se desplaza en tierra, como un automóvil o una motocicleta.
    /// </summary>
    public class VehiculoTerrestre
    {
        // Atributos

        /// <summary>
        /// Campo privado que almacena la cantidad de ruedas del vehículo terrestre.
        /// </summary>
        private short cantidadRuedas;

        /// <summary>
        /// Campo privado que almacena la cantidad de puertas del vehículo terrestre.
        /// </summary>
        private short cantidadPuertas;

        /// <summary>
        /// Campo privado que almacena el color del vehículo terrestre.
        /// </summary>
        private Color color;

        // Constructor

        /// <summary>
        /// Constructor de la clase <see cref="VehiculoTerrestre"/> que acepta la cantidad de ruedas, la cantidad de puertas y el color del vehículo.
        /// </summary>
        /// <param name="cantidadRuedas">La cantidad de ruedas del vehículo terrestre.</param>
        /// <param name="cantidadPuertas">La cantidad de puertas del vehículo terrestre.</param>
        /// <param name="color">El color del vehículo terrestre.</param>
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Color color)
        {
            // Propósito: Inicializa una instancia de la clase VehiculoTerrestre con la cantidad de ruedas, la cantidad de puertas y el color especificados.
            // Precondiciones:
            // - La cantidad de ruedas debe ser un número positivo.
            // - La cantidad de puertas debe ser un número positivo.
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        // Propiedades

        /// <summary>
        /// Propiedad pública para acceder y modificar la cantidad de ruedas del vehículo terrestre.
        /// </summary>
        public short CantidadRuedas
        {
            get { return cantidadRuedas; }
            set
            {
                // Propósito: Establece la cantidad de ruedas del vehículo terrestre, asegurándose de que sea un número positivo.
                // Precondiciones: El valor debe ser un número positivo.
                if (value > 0) cantidadRuedas = value;
            }
        }

        /// <summary>
        /// Propiedad pública para acceder y modificar la cantidad de puertas del vehículo terrestre.
        /// </summary>
        public short CantidadPuertas
        {
            get { return cantidadPuertas; }
            set
            {
                // Propósito: Establece la cantidad de puertas del vehículo terrestre, asegurándose de que sea un número positivo.
                // Precondiciones: El valor debe ser un número positivo.
                if (value > 0) cantidadPuertas = value;
            }
        }

        /// <summary>
        /// Propiedad pública para acceder y modificar el color del vehículo terrestre.
        /// </summary>
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
