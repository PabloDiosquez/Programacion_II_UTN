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
            // Arrange -- Preparar el método de prueba

            Calculadora calculadora = new Calculadora();

            double divisor = 0;

            double resultadoEsperado = double.MaxValue;
             
            // Act -- Invocación al método a probar

            double resultado = calculadora.Dividir(2, divisor);

            // Assert -- Verifico que el resultado sea el esperado

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void Dividir_CuandoElDivisorEsIgualAlDividendo_DeberiaRetornarUno()
        {
            // Arrange

            Calculadora calculadora = new Calculadora();

            double divisor = 2;

            double resultadoEsperado = 1;

            // Act 

            double resultado = calculadora.Dividir(2, divisor);

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void Dividir_CuandoElDivisorNoEsIgualACero_DeberiaRetornarResultadoDivision()
        {
            // Arrange

            Calculadora calculadora = new Calculadora();

            double divisor = 2;

            double resultadoEsperado = 1.5;

            // Act 

            double resultado = calculadora.Dividir(3, divisor);

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
