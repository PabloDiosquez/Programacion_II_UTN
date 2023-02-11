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
    internal class StringExtensionTest
    {
        [TestMethod]
        public void ContadorDeVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            // Arrange 
            int resultadoEsperado = 0;

            string texto = "tyRyu nwq! ;";

            // Act
            int resultado = StringExtension.ContadorDeVocales(texto);

            // Assert 
            Assert.AreEqual(resultadoEsperado, resultado);

        }
    }
}
