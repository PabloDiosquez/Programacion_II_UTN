using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace Pruebas
{
    [TestClass]
    public class CalculadoraPruebas
    {
        [TestMethod]
        public void Dividir_CuandoElDivisorEsCero_DeberiaRetornarDoubleMinValue()
        {
            // Arrange

            Calculadora calculadora = new Calculadora();

            double divisor = 0;

            double resultadoEsperado = double.MinValue;

            // Act

            double resultado = calculadora.Dividir(2, divisor);

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
