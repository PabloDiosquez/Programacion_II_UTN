using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca_I02;

namespace Pruebas_I02
{
    [TestClass]
    public class IntExtendidoPruebas
    {
        [TestMethod]
        public void ContadorDigitos_CuandoLePasamosUno_DeberiaRetornarUno()
        {
            // Arrange

            int numero = 1;

            int resultadoEsperado = 1;

            // Act

            int resultado = numero.ContadorDigitos();

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ContadorDigitos_CuandoLePasamosCien_DeberiaRetornarTres()
        {
            // Arrange

            int numero = 100;

            int resultadoEsperado = 3;

            // Act

            int resultado = numero.ContadorDigitos();

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ContadorDigitos_CuandoLePasamosMenosDiez_DeberiaRetornarDos()
        {
            // Arrange

            int numero = -10;

            int resultadoEsperado = 2;

            // Act

            int resultado = numero.ContadorDigitos();

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ContadorDigitosII_CuandoLePasamosUno_DeberiaRetornarUno()
        {
            // Arrange

            int numero = 1;

            int resultadoEsperado = 1;

            // Act

            int resultado = numero.ContadorDigitosII();

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ContadorDigitosII_CuandoLePasamosCien_DeberiaRetornarTres()
        {
            // Arrange

            int numero = 100;

            int resultadoEsperado = 3;

            // Act

            int resultado = numero.ContadorDigitosII();

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ContadorDigitosII_CuandoLePasamosMenosDiez_DeberiaRetornarDos()
        {
            // Arrange

            int numero = -10;

            int resultadoEsperado = 2;

            // Act

            int resultado = numero.ContadorDigitosII();

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
