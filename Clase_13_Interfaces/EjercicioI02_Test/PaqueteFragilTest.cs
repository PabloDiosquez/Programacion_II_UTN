using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioI02_Biblioteca;

namespace EjercicioI02_Test
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            // Arrange 

            const decimal costoEnvio = 100;

            const decimal resultadoEsperado = 135;

            PaqueteFragil paqueteFragil = new PaqueteFragil(string.Empty, costoEnvio, string.Empty, string.Empty, 0);

            // Act 

            decimal resultado = paqueteFragil.AplicarImpuestos();

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            // Arrange

            const decimal costoEnvio = 100;

            PaqueteFragil paqueteFragil = new PaqueteFragil(string.Empty, costoEnvio, string.Empty, string.Empty, 0);

            decimal resultadoEsperado = 35;

            // Act 

            decimal resultado = paqueteFragil.Impuestos;
            
            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
            
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue() 
        {
            // Arrange

            PaqueteFragil paqueteFragil = new PaqueteFragil(string.Empty, 0, string.Empty, string.Empty, 0);

            // Act 

            bool resultado = paqueteFragil.TienePrioridad;

            // Assert 

            Assert.IsTrue(resultado);
        }
    }
}
