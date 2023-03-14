using System;

namespace Entidades
{
    public static class Cotizador
    {
        private const decimal pesosPorDolarComprado = 96.75M;

        private const decimal pesosPorDolarVendido = 102.82M;

        public static decimal CotizarVentaDolares(decimal montoDolaresAVender)
        {
            decimal costoEnPesos = montoDolaresAVender * pesosPorDolarComprado;

            return costoEnPesos;    
        }

        public static decimal CotizarCompraDolares(decimal montoDolaresAComprar)
        {
            decimal pagoEnPesos = montoDolaresAComprar * pesosPorDolarComprado;

            return pagoEnPesos;
        }



    }
}
