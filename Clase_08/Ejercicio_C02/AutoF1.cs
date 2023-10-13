using System;
using System.Text;

namespace Ejercicio_C02
{

    /// <summary>
    /// Clase que representa un auto de Fórmula 1, que hereda de la clase VehiculoDeCarrera.
    /// </summary>
    public class AutoF1 : VehiculoDeCarrera
    {
        // Atributos 

        /// <summary>
        /// Cantidad de caballos de fuerza del auto de Fórmula 1.
        /// </summary>
        private short caballosDeFuerza;

        // Constructor 

        /// <summary>
        /// Constructor de la clase AutoF1. Inicializa un objeto AutoF1 con número y escudería.
        /// </summary>
        /// <param name="numero">Número del auto de Fórmula 1.</param>
        /// <param name="escuderia">Nombre de la escudería a la que pertenece el auto.</param>
        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
            // El constructor base (de la clase VehiculoDeCarrera) se encarga de inicializar el número y escudería.
        }

        /// <summary>
        /// Constructor de la clase AutoF1. Inicializa un objeto AutoF1 con número, escudería y cantidad de caballos de fuerza.
        /// </summary>
        /// <param name="numero">Número del auto de Fórmula 1.</param>
        /// <param name="escuderia">Nombre de la escudería a la que pertenece el auto.</param>
        /// <param name="caballosDeFuerza">Cantidad de caballos de fuerza del auto de Fórmula 1.</param>
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        // Getters y Setters 

        /// <summary>
        /// Obtiene y establece la cantidad de caballos de fuerza del auto de Fórmula 1.
        /// </summary>
        public short CaballosDeFuerza
        {
            get { return caballosDeFuerza; }
            set { this.caballosDeFuerza = (short)((value > 0) ? value : 0); }
        }

        public 

        // Métodos de instancia 

        /// <summary>
        /// Sobrescribe el método ToString para representar el auto de Fórmula 1 como una cadena.
        /// </summary>
        /// <returns>Una cadena que representa el auto de Fórmula 1.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()); // Llama al método ToString de la clase base (VehiculoDeCarrera).
            sb.AppendLine($"Caballos de fuerza: {CaballosDeFuerza}");
            return sb.ToString();
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Sobrecarga del operador de igualdad (==) para comparar dos autos de Fórmula 1 y determinar si son iguales en número y caballos de fuerza.
        /// </summary>
        /// <param name="auto1">Primer auto de Fórmula 1 a comparar.</param>
        /// <param name="auto2">Segundo auto de Fórmula 1 a comparar.</param>
        /// <returns>True si los autos son iguales; de lo contrario, false.</returns>
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            // Realiza una comparación basada en la igualdad de la clase base (VehiculoDeCarrera)
            bool comparacionBase = (VehiculoDeCarrera)auto1 == (VehiculoDeCarrera)auto2;

            // Agrega una condición adicional para comparar los caballos de fuerza.
            return comparacionBase && auto1.CaballosDeFuerza == auto2.CaballosDeFuerza;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad (!=) para comparar dos autos de Fórmula 1 y determinar si son diferentes en número o caballos de fuerza.
        /// </summary>
        /// <param name="auto1">Primer auto de Fórmula 1 a comparar.</param>
        /// <param name="auto2">Segundo auto de Fórmula 1 a comparar.</param>
        /// <returns>True si los autos son diferentes; de lo contrario, false.</returns>
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
    }
}
