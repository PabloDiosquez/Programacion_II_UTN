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
    public class StringExtendidoPruebas
    {
        [TestMethod]

        public void ContadorDeVocales_CuandoElStringNoTieneVocales_DeberiaRetornarCero()
        {
            // Arrange

            string texto = "¡ Brrrr!    -- ;¡ Ssssh!";

            int resultadoEsperado = 0;

            // Act 

            int resultado = StringExtendido.ContadorDeVocales(texto);

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ContadorDeVocales_CuandoElStringTieneDosVocalesEnMinuscula_DeberiaRetornarDos()
        {
            // Arrange

            string texto = "¡ Brerrr!    -- ;¡ Sasssh!";

            int resultadoEsperado = 2;

            // Act 

            int resultado = texto.ContadorDeVocales(); // Método de extensión 🖖🏼

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ContadorDeVocales_CuandoElStringTieneTresVocalesEnMayuscula_DeberiaRetornarTres()
        {
            // Arrange

            string texto = "¡ BrErrr! U   -- ;¡ SAsssh!";

            int resultadoEsperado = 3;

            // Act 

            int resultado = texto.ContadorDeVocales();

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ContadorDeVocales_CuandoElStringEsNulo_DeberiaRetornarCero()
        {
            // Arrange

            string texto = null;

            int resultadoEsperado = 0;

            // Act 

            int resultado = texto.ContadorDeVocales();

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ContadorDeVocales_CuandoElStringEsVacio_DeberiaRetornarCero()
        {
            // Arrange

            string texto = string.Empty;

            int resultadoEsperado = 0;

            // Act 

            int resultado = texto.ContadorDeVocales();

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void ContarCaracter_CuandoElStringEsNulo_DeberiaRetornarCero()
        {
            // Arrange

            string texto = null;

            int resultadoEsperado = 0;

            char caracter = 'a';

            // Act 

            int resultado = texto.ContarCaracter(caracter);

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);


        }

        [TestMethod]

        public void ContarCaracter_CuandoElStringEsVacio_DeberiaRetornarCero()
        {
            // Arrange

            string texto = string.Empty;

            int resultadoEsperado = 0;

            char caracter = 'a';

            // Act 

            int resultado = texto.ContarCaracter(caracter);

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void ContarCaracter_CuandoElStringNoTieneAlCaracter_DeberiaRetornarCero()
        {
            // Arrange

            string texto = "¡ Brerrr! U   -- ;¡ SAsssh!";

            char caracter = 'a';

            int resultadoEsperado = 0;

            // Act 

            int resultado = texto.ContarCaracter(caracter);

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void ContarCaracter_CuandoElCaracterApareceUnaVezEnElString_DeberiaRetornarUno()
        {
            // Arrange

            string texto = "¡ BrErrr! U   -- ;¡ SAsssh!";

            char caracter = 'E';

            int resultadoEsperado = 1;

            // Act

            int resultado = texto.ContarCaracter(caracter);

            // Assert 

            Assert.AreEqual(resultadoEsperado, resultado);
        }


    }
}
