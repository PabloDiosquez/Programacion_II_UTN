using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Aduana;

namespace Pruebas_Aduana
{
    [TestClass]
    internal class PaquetePesadoPruebas
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            // Arrange

            PaquetePesado paquetePesado = new PaquetePesado("test", 1, "test", "test", 1);

            // Act

            bool valorRetornado = paquetePesado.TienePrioridad;

            // Assert
            
            Assert.IsFalse(valorRetornado);
        }
    }
}
