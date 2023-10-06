using System;
using System.Text;

namespace Ejercicio_5_C02
{
    public class AutoF1
    {
        // Atributos

        private short cantidadDeCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        // Constructor

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            enCompetencia = false;
            cantidadDeCombustible = 0;
            vueltasRestantes = 0;
        }

        // Métodos de instancia

        /// <summary>
        /// Obtiene el número del automóvil.
        /// </summary>
        /// <returns>El número del automóvil.</returns>
        public short GetNumero()
        {
            return numero;
        }

        /// <summary>
        /// Obtiene la escudería del automóvil.
        /// </summary>
        /// <returns>La escudería del automóvil.</returns>
        public string GetEscuderia()
        {
            return escuderia;
        }

        /// <summary>
        /// Verifica si el automóvil está en competencia.
        /// </summary>
        /// <returns>True si el automóvil está en competencia, false si no lo está.</returns>
        public bool EstaEnCompetencia()
        {
            return enCompetencia;
        }

        /// <summary>
        /// Establece el estado de competencia del automóvil.
        /// </summary>
        /// <param name="estado">True para marcar como en competencia, false para marcar como fuera de competencia.</param>
        public void SetEnCompetencia(bool estado)
        {
            this.enCompetencia = estado;
        }

        /// <summary>
        /// Obtiene la cantidad de combustible del automóvil.
        /// </summary>
        /// <returns>La cantidad de combustible.</returns>
        public short GetCantidadDeCombustible()
        {
            return cantidadDeCombustible;
        }

        /// <summary>
        /// Establece la cantidad de combustible del automóvil.
        /// </summary>
        /// <param name="cantidadDeCombustible">La cantidad de combustible a establecer.</param>
        public void SetCantidadDeCombustible(short cantidadDeCombustible)
        {
            if (cantidadDeCombustible > 0)
            {
                this.cantidadDeCombustible = cantidadDeCombustible;
            }
            else
            {
                this.cantidadDeCombustible = 0;
            }
        }

        /// <summary>
        /// Obtiene las vueltas restantes del automóvil.
        /// </summary>
        /// <returns>Las vueltas restantes.</returns>
        public short GetVueltasRestantes()
        {
            return vueltasRestantes;
        }

        /// <summary>
        /// Establece las vueltas restantes del automóvil.
        /// </summary>
        /// <param name="vueltasRestantes">Las vueltas restantes a establecer.</param>
        public void SetVueltasRestantes(short vueltasRestantes)
        {
            if (vueltasRestantes > 0)
            {
                this.vueltasRestantes = vueltasRestantes;
            }
            else
            {
                this.vueltasRestantes = 0;
            }
        }

        /// <summary>
        /// Muestra los datos del automóvil en forma de cadena de texto.
        /// </summary>
        /// <returns>Los datos del automóvil.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**** Datos del automóvil ****");
            sb.AppendLine($"Número: {numero}");
            sb.AppendLine($"Escudería: {escuderia}");
            if (enCompetencia) sb.AppendLine("Estado: En competencia");
            else sb.AppendLine("Estado: Fuera de competencia");
            sb.AppendLine($"Cantidad de combustible: {cantidadDeCombustible}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");

            return sb.ToString();
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Compara dos automóviles por número y escudería para determinar si son iguales.
        /// </summary>
        /// <param name="auto1">El primer automóvil a comparar.</param>
        /// <param name="auto2">El segundo automóvil a comparar.</param>
        /// <returns>True si los automóviles son iguales, false si no lo son.</returns>
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            return auto1.numero == auto2.numero && auto1.escuderia == auto2.escuderia;
        }

        /// <summary>
        /// Compara dos automóviles por número y escudería para determinar si son diferentes.
        /// </summary>
        /// <param name="auto1">El primer automóvil a comparar.</param>
        /// <param name="auto2">El segundo automóvil a comparar.</param>
        /// <returns>True si los automóviles son diferentes, false si son iguales.</returns>
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
    }
}
