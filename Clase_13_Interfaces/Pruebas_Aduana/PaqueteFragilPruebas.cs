using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca_Aduana;

namespace Pruebas_Aduana
{
    [TestClass]
    public class PaqueteFragilPruebas
    {
        [TestMethod]
        public void TienePrioridadDeberiaRetornarTrue()
        {
            // Arrange

            PaqueteFragil paqueteFragil = new PaqueteFragil("test", 1, "test", "test", 1);

            // Act

            bool valorRetornado = paqueteFragil.TienePrioridad;

            // Assert

             Assert.IsTrue(valorRetornado);
        }
    }
}
