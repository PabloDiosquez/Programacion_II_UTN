using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02
{
    /// <summary>
    /// Clase que representa un vehículo de motocross.
    /// </summary>
    public class Motocross : VehiculoDeCarrera
    {
        // Atributos
        private short cilindrada;

        // Constructores

        /// <summary>
        /// Constructor que inicializa un objeto Motocross con número y escudería.
        /// </summary>
        /// <param name="numero">Número del vehículo.</param>
        /// <param name="escuderia">Nombre de la escudería.</param>
        public Motocross(short numero, string escuderia) : base(numero, escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        /// <summary>
        /// Constructor que inicializa un objeto Motocross con número, escudería y cilindrada.
        /// </summary>
        /// <param name="numero">Número del vehículo.</param>
        /// <param name="escuderia">Nombre de la escudería.</param>
        /// <param name="cilindrada">Cilindrada de la motocross.</param>
        public Motocross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece la cilindrada de la motocross.
        /// </summary>
        public short Cilindrada
        {
            get { return cilindrada; }
            set { this.cilindrada = (short)((value > 0) ? value : 0); }
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Compara dos objetos Motocross para determinar si son iguales en número y cilindrada.
        /// </summary>
        /// <param name="moto1">Primer objeto Motocross a comparar.</param>
        /// <param name="moto2">Segundo objeto Motocross a comparar.</param>
        /// <returns>Verdadero si los objetos son iguales; de lo contrario, falso.</returns>
        public static bool operator ==(Motocross moto1, Motocross moto2)
        {
            // Llama al operador de la superclase para comparar los números
            bool comparacionBase = (VehiculoDeCarrera)moto1 == (VehiculoDeCarrera)moto2;

            return comparacionBase && moto1.cilindrada == moto2.cilindrada;
        }

        /// <summary>
        /// Compara dos objetos Motocross para determinar si son diferentes en número o cilindrada.
        /// </summary>
        /// <param name="moto1">Primer objeto Motocross a comparar.</param>
        /// <param name="moto2">Segundo objeto Motocross a comparar.</param>
        /// <returns>Verdadero si los objetos son diferentes; de lo contrario, falso.</returns>
        public static bool operator !=(Motocross moto1, Motocross moto2)
        {
            return !(moto1 == moto2);
        }
    }
}
