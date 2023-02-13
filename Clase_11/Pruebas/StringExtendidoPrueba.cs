using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

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

            Assert.Equals(resultadoEsperado, resultado);
        }
    }
}
