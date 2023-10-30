using System;
using System.Text;

namespace EjercicioC01_Biblioteca
{
    /// <summary>
    /// Clase que representa un Auto de Fórmula 1.
    /// </summary>
    public class AutoF1 : VehiculoDeCarrera
    {
        // Atributos

        private short caballosDeFuerza;

        // Constructores

        public AutoF1(short numero, string escuderia) : base(numero, escuderia) 
        {
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        // Propiedades 

        public short CaballosDeFuerza { get; }
        
        // Métodos de instancia

        /// <summary>
        /// Muestra los datos del auto.
        /// </summary>
        /// <returns>Una cadena que contiene los datos del auto.</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de Fuerza: {this.CaballosDeFuerza}");

            return sb.ToString();
        }

        // SobreCarga de operadores 

        /// <summary>
        /// Compara si dos autos de Fórmula 1 son iguales por escudería, número de identificación
        /// y caballos de fuerza.
        /// </summary>
        /// <param name="auto1">Primer auto a comparar.</param>
        /// <param name="auto2">Segundo auto a comparar.</param>
        /// <returns>Verdadero si los autos son iguales, falso en caso contrario.</returns>
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            if (auto1 is null || auto2 is null) return false;

            bool comparacionBase = (VehiculoDeCarrera)auto1 == auto2;
            
            return comparacionBase && auto1.CaballosDeFuerza == auto2.CaballosDeFuerza;
        }

        /// <summary>
        /// Compara si dos autos de Fórmula 1 son diferentes por escudería, número de identificación
        /// y caballos de fuerza.
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
