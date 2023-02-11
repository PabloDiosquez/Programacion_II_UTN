using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Pruebas
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Dividir_CuandoElDivisorEsCero_DeberiaRetornarDoubleMinValue()
        {
            // Arrange 👉🏼 Preparar el caso de prueba
            double divisor = 0;

            Calculadora calculadora = new Calculadora();

            double resultadoEsperado = Double.MinValue;

            // Act 👉🏼 Invocar el método a probar
            double resultado = calculadora.Dividir(2, divisor);

            // Assert 👉🏼 Verifico que el resultado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Dividir_CuandoElDivisorNoEsCero_DeberiaRetornarResultadoDivision()
        {
            // Arrange 👉🏼 Preparar el caso de prueba
            double divisor = 2;

            Calculadora calculadora = new Calculadora();

            double resultadoEsperado = 1;

            // Act 👉🏼 Invocar el método a probar
            double resultado = calculadora.Dividir(2, divisor);

            // Assert 👉🏼 Verifico que el resultado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}
