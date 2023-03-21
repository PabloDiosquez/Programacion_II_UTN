using System;

namespace Entidades
{
    public static class Cotizador
    {
        private const decimal pesosPorDolarComprado = 96.75M;

        private const decimal pesosPorDolarVendido = 102.82M;

        /// <summary>
        /// Cotiza la venta de un monto de dólares dado, retornando el costo en pesos.
        /// </summary>
        /// <param name="montoDolaresAVender">Cantidad de dólares que se desean vender.</param>
        /// <returns>Costo en pesos de la venta.</returns>
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
