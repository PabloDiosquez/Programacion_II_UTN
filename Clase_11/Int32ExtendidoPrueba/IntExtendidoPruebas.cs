using Microsoft.VisualStudio.TestTools.UnitTesting;
using Int32Extendido;

namespace Int32ExtendidoPrueba
{
    /// <summary>
    /// Clase de pruebas unitarias para validar el comportamiento del método FizzBuzz en números enteros extendidos.
    /// </summary>
    [TestClass]
    public class IntExtendidoPruebas
    {
        /// <summary>
        /// Prueba unitaria para el método FizzBuzz cuando el número solo es divisible por tres. 
        /// Debería retornar "Fizz" como resultado.
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
        /// Prueba unitaria para el método FizzBuzz cuando el número solo es divisible por cinco.
        /// Debería retornar "Buzz" como resultado.
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
        /// Prueba unitaria para el método FizzBuzz cuando el número es divisible por tres y por cinco.
        /// Debería retornar "FizzBuzz" como resultado.
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
        /// Prueba unitaria para el método FizzBuzz cuando el número no es divisible ni por tres ni por cinco.
        /// Debería retornar el número convertido a cadena como resultado.
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
