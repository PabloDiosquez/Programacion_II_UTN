using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
using System;

namespace Pruebas
{
    [TestClass]
    public class StringExtendidoPrueba
    {
        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabras_DeberiaRetornarDos()
        {
            // Patrón AAA

            // Arrange 👉🏼 Preparación

            string texto = "Hola mundo";

            int resultadoEsperado = 2;

            // Act 👉🏼 Invocación a los métodos a probar

            int resultado = texto.ContarPalabras();

            // Assert 👉🏼 Evaluación de los resultados

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void ContarPalabras_CuandoRecibeStringVacio_DeberiaLanzarArgumentException()
        {
            // Arrange
            string texto = string.Empty;

            // Act

            texto.ContarPalabras();

        }

        [TestMethod]

        public void ContarPalabras_CuandoRecibeDosPalabrasSeparadasPorGuion_DeberiaRetornarDos()
        {
            // Arrange

            string texto = "Hola-Mundo";

            int resultadoEsperado = 2;

            // Act

            int resultado = texto.ContarPalabras();

            // Assert

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
