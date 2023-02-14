using Microsoft.VisualStudio.TestTools.UnitTesting;
using Int32Extendido;

namespace Int32ExtendidoPrueba
{
    [TestClass]
    public class IntExtendidoPruebas
    {
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
