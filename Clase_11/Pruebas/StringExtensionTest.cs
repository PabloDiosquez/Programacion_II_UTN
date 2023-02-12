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
    public class StringExtensionTest
    {
        public object StringExtension { get; private set; }

        [TestMethod]
        public void ContadorDeVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            // Arrange 
            int resultadoEsperado = 0;

            string texto = "¡ Pssst! ¡ Bzzzz!   ;?' Zzz..";

            // Act
            int resultado = StringExtension.ContadorDeVocales(texto);

            // Assert 
            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void ContadorDeVocales_CuandoTieneDosVocalesEnMinuscula_DeberiaRetornarDos()
        {
            // Arrange 
            int resultadoEsperado = 2;

            string texto = "¡ Pssat! ¡ Buzzz!   ;?' Zzz..";

            // Act
            int resultado = StringExtension.ContadorDeVocales(texto);

            // Assert 
            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void ContadorDeVocales_CuandoTieneTresVocalesEnMayuscula_DeberiaRetornarTres()
        {
            // Arrange 
            int resultadoEsperado = 3;

            string texto = "¡ PssAt! ¡ BUzzz! E  ;?' Zzz..";

            // Act
            int resultado = StringExtension.ContadorDeVocales(texto);

            // Assert 
            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void ContadorDeVocales_CuandoElTextoEsVacio_DeberiaRetornarCero()
        {
            // Arrange 
            int resultadoEsperado = 0;

            string texto = string.Empty;

            // Act
            int resultado = StringExtension.ContadorDeVocales(texto);

            // Assert 
            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void ContadorDeVocales_CuandoElTextoEsNulo_DeberiaRetornarCero()
        {
            // Arrange 
            int resultadoEsperado = 0;

            string texto = null;

            // Act
            int resultado = StringExtension.ContadorDeVocales(texto);

            // Assert 
            Assert.AreEqual(resultadoEsperado, resultado);

        }
    }
}
