using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_EjercicioI01;

namespace Test_EjericioI01
{
    [TestClass]
    public class Test_MetodoAdd
    {
        [TestMethod]

        public void Add_CuandoRecibeStringVacio_DeberiaRetornarElNumeroCero()
        {
            // Arrange

            string str = string.Empty;

            int resultadoEsperado = 0;

            // Act 

            int resultado = CalculadoraDeStrings.Add(str);

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void Add_CuandoRecibeUnUnicoNumero_DeberiaRetornarElNumeroCero()
        {
            // Arrange

            string str = "1,";

            int resultadoEsperado = 0;

            // Act 

            int resultado = CalculadoraDeStrings.Add(str);

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void Add_CuandoRecibeDosNumerosSeparadosPorComa_DeberiaRetornarSuSumaNumerica()
        {
            // Arrange

            string str = "1,2";

            int resultadoEsperado = 3;

            // Act 

            int resultado = CalculadoraDeStrings.Add(str);

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        public void Add_CuandoRecibeTresNumerosSeparadosPorComa_DeberiaRetornarSuSumaNumerica()
        {
            // Arrange

            string str = "1,2,3";

            int resultadoEsperado = 6;

            // Act 

            int resultado = str.Add();

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Add_CuandoRecibeTresNumerosSeparadosPorUnSaltoDeLinea_DeberiaRetornarSuSumaNumerica()
        {
            // Arrange 

            string str = "1\n2,3";

            int resultadoEsperado = 6;

            // Act

            int resultado = str.Add();

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]

        public void Add_CuandoNoPuedeCastearAEntero_DeberiaLanzarInvalidCastException()
        {
            // Arrange

            string str = "Hola, soy una cadena sin números";

            // Act

            int resultado = str.Add();
        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]

        public void Add_CuandoRecibeUnNumeroNegativo_DeberíaLanzarNegativoNoPermitidoException()
        {
            // Arrange

            string str = "1, -2";

            // Act

            int resultado = str.Add();
        }
    }
}
