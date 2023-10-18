using Microsoft.VisualStudio.TestTools.UnitTesting;
using Int32Extendido;

namespace Int32ExtendidoPrueba
{
    /// <summary>
    /// Clase de pruebas unitarias para validar el comportamiento del m�todo FizzBuzz en n�meros enteros extendidos.
    /// </summary>
    [TestClass]
    public class IntExtendidoPruebas
    {
        /// <summary>
        /// Prueba unitaria para el m�todo FizzBuzz cuando el n�mero solo es divisible por tres. 
        /// Deber�a retornar "Fizz" como resultado.
        /// </summary>
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroSoloEsDivisiblePorTres_DeberiaRetornarFizz()
        {
            // Arrange
            int numero = 12;
            string resultadoEsperado = "Fizz";

            // Act
            string resultado = numero.FizzBuzz();

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        /// <summary>
        /// Prueba unitaria para el m�todo FizzBuzz cuando el n�mero solo es divisible por cinco.
        /// Deber�a retornar "Buzz" como resultado.
        /// </summary>
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroSoloEsDivisiblePorCinco_DeberiaRetornarBuzz()
        {
            // Arrange 
            int numero = 25;
            string resultadoEsperado = "Buzz";

            // Act 
            string resultado = numero.FizzBuzz();

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        /// <summary>
        /// Prueba unitaria para el m�todo FizzBuzz cuando el n�mero es divisible por tres y por cinco.
        /// Deber�a retornar "FizzBuzz" como resultado.
        /// </summary>
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePorTresYPorCinco_DeberiaRetornarFizzBuzz()
        {
            // Arrange 
            int numero = 15;
            string resultadoEsperado = "FizzBuzz";

            // Act 
            string resultado = numero.FizzBuzz();

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        /// <summary>
        /// Prueba unitaria para el m�todo FizzBuzz cuando el n�mero no es divisible ni por tres ni por cinco.
        /// Deber�a retornar el n�mero convertido a cadena como resultado.
        /// </summary>
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroNoEsDivisibleNiPorTresNiPorCinco_DeberiaRetornarElNumeroConvertidoAString()
        {
            // Arrange 
            int numero = 7;
            string resultadoEsperado = "7";

            // Act 
            string resultado = numero.FizzBuzz();

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
