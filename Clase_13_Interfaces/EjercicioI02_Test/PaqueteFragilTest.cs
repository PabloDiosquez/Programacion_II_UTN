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
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {

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
