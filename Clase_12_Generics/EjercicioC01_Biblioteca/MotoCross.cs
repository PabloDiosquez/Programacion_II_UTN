using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01_Biblioteca
{
    /// <summary>
    /// Clase que representa una motocross, un tipo de vehículo de carrera.
    /// </summary>
    public class MotoCross : VehiculoDeCarrera
    {
        // Atributos 

        /// <summary>
        /// Cilindrada de la motocross.
        /// </summary>
        private short cilindrada;

        // Constructores 

        /// <summary>
        /// Constructor de la clase MotoCross que inicializa el número y la escudería de la motocross.
        /// </summary>
        /// <param name="numero">Número de identificación de la motocross.</param>
        /// <param name="escuderia">Nombre de la escudería a la que pertenece la motocross.</param>
        public MotoCross(short numero, string escuderia) : base(numero, escuderia) { }

        /// <summary>
        /// Constructor de la clase MotoCross que inicializa el número, la escudería y la cilindrada de la motocross.
        /// </summary>
        /// <param name="numero">Número de identificación de la motocross.</param>
        /// <param name="escuderia">Nombre de la escudería a la que pertenece la motocross.</param>
        /// <param name="cilindrada">Cilindrada de la motocross.</param>
        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece la cilindrada de la motocross.
        /// </summary>
        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        // Métodos de instancia

        /// <summary>
        /// Muestra los datos de la motocross, incluyendo número, escudería y cilindrada.
        /// </summary>
        /// <returns>Una cadena que contiene los datos de la motocross.</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.Cilindrada}");

            return sb.ToString();
        }

        // Sobrecarga de operadores 

        /// <summary>
        /// Compara si dos motocross son iguales por número de identificación, escudería y cilindrada.
        /// </summary>
        /// <param name="moto1">Primera motocross a comparar.</param>
        /// <param name="moto2">Segunda motocross a comparar.</param>
        /// <returns>Verdadero si las motocross son iguales, falso en caso contrario.</returns>
        public static bool operator ==(MotoCross moto1, MotoCross moto2)
        {
            bool comparacionBase = (VehiculoDeCarrera)moto1 == moto2;

            return comparacionBase && moto1.cilindrada == moto2.cilindrada;
        }

        /// <summary>
        /// Compara si dos motocross son diferentes por número de identificación, escudería o cilindrada.
        /// </summary>
        /// <param name="moto1">Primera motocross a comparar.</param>
        /// <param name="moto2">Segunda motocross a comparar.</param>
        /// <returns>Verdadero si las motocross son diferentes, falso en caso contrario.</returns>
        public static bool operator !=(MotoCross moto1, MotoCross moto2)
        {
            return !(moto1 == moto2);
        }
    }
}
