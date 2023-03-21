using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que contiene funcionalidades para convertir temperaturas.
    /// </summary>
    public static class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;

        /// <summary>
        /// Convierte una temperatura en grados Celsius a grados Kelvin.
        /// </summary>
        /// <param name="temperaturaCelsius">Temperatura en grados Celsius a convertir</param>
        /// <returns>Temperatura en grados Kelvin correspondiente al argumento proporcionado.</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;

            return temperaturaKelvin;
        }

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            float temperaturaCelsius = temperaturaKelvin - ceroAbsoluto;

            return temperaturaCelsius;
        }
    }
}
