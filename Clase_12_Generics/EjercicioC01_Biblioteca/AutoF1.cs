using System;
using System.Text;

namespace EjercicioC01_Biblioteca
{
    /// <summary>
    /// Clase que representa un Auto de Fórmula 1.
    /// </summary>
    public class AutoF1
    {
        // Atributos

        /// <summary>
        /// Cantidad de combustible del auto.
        /// </summary>
        private short cantidadCombustible;

        /// <summary>
        /// Indica si el auto está en competencia.
        /// </summary>
        private bool enCompetencia;

        /// <summary>
        /// Nombre de la escudería a la que pertenece el auto.
        /// </summary>
        private string escuderia;

        /// <summary>
        /// Número de identificación del auto.
        /// </summary>
        private short numero;

        /// <summary>
        /// Cantidad de vueltas restantes del auto.
        /// </summary>
        private short vueltasRestantes;

        // Constructor 

        /// <summary>
        /// Constructor de la clase AutoF1.
        /// </summary>
        /// <param name="numero">Número de identificación del auto.</param>
        /// <param name="escuderia">Nombre de la escudería a la que pertenece el auto.</param>
        public AutoF1(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece la cantidad de combustible del auto.
        /// </summary>
        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }

        /// <summary>
        /// Obtiene o establece un valor que indica si el auto está en competencia.
        /// </summary>
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }

        /// <summary>
        /// Obtiene o establece el nombre de la escudería a la que pertenece el auto.
        /// </summary>
        public string Escuderia { get => escuderia; set => escuderia = value; }

        /// <summary>
        /// Obtiene o establece el número de identificación del auto.
        /// </summary>
        public short Numero { get => numero; set => numero = value; }

        /// <summary>
        /// Obtiene o establece la cantidad de vueltas restantes del auto.
        /// </summary>
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        // Métodos de instancia

        /// <summary>
        /// Muestra los datos del auto.
        /// </summary>
        /// <returns>Una cadena que contiene los datos del auto.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Datos del Auto F1 ***");
            sb.AppendLine($"Número: {this.Numero}");
            sb.AppendLine($"Escudería: {this.Escuderia}");
            if (this.EnCompetencia)
            {
                sb.AppendLine($"Auto en competencia.");
                sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");
                sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");
            }
            else
                sb.AppendLine("Auto fuera de competencia.");

            return sb.ToString();
        }

        // SobreCarga de operadores 

        /// <summary>
        /// Compara si dos autos de Fórmula 1 son iguales por escudería y número de identificación.
        /// </summary>
        /// <param name="auto1">Primer auto a comparar.</param>
        /// <param name="auto2">Segundo auto a comparar.</param>
        /// <returns>Verdadero si los autos son iguales, falso en caso contrario.</returns>
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            if (auto1 is null || auto2 is null) return false;

            return auto1.Escuderia == auto2.Escuderia && auto1.Numero == auto2.Numero;
        }

        /// <summary>
        /// Compara si dos autos de Fórmula 1 son diferentes por escudería y número de identificación.
        /// </summary>
        /// <param name="auto1">Primer auto a comparar.</param>
        /// <param name="auto2">Segundo auto a comparar.</param>
        /// <returns>Verdadero si los autos son diferentes, falso en caso contrario.</returns>
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
    }
}
