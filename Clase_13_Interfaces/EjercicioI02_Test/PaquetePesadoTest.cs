using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioI02_Biblioteca;

namespace EjercicioI02_Test
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAfipYAduana()
        {
            // Arrange

            const decimal costoEnvio = 100;

            const decimal resultadoEsperado = 160;

            PaquetePesado paquetePesado = new PaquetePesado(string.Empty, costoEnvio, string.Empty, string.Empty, 0);

            // Act 

            decimal resultado = paquetePesado.AplicarImpuestos();

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            // Arrange

            const decimal costoEnvio = 100;

            const decimal resultadoEsperado = 25;

            PaquetePesado paquetePesado = new PaquetePesado(string.Empty, costoEnvio, string.Empty, string.Empty, 0);

            // Act 

            decimal resultado = ((IAfip)paquetePesado).Impuestos;

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            // Arrange

            const decimal costoEnvio = 100;

            const decimal resultadoEsperado = 35;

            PaquetePesado paquetePesado = new PaquetePesado(string.Empty, costoEnvio, string.Empty, string.Empty, 0);

            // Act 

            decimal resultado = paquetePesado.Impuestos;

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse() 
        {
            // Arrange 

            PaquetePesado paquetePesado = new PaquetePesado(string.Empty, 0, string.Empty, string.Empty, 0);

            // Act 

            bool restultado = paquetePesado.TienePrioridad;

            // Assert 

            Assert.IsFalse(restultado);
        }
    }
}
