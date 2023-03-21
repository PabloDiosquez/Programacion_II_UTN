using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;

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
