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
    public class PaquetePesadoPruebas
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

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            // Arrange

            decimal costoEnvio = 100;

            decimal valorEsperado = 35;

            PaquetePesado paquetePesado = new PaquetePesado("test", costoEnvio, "test", "test", 1);

            // Act
              
            decimal valorRetornado = paquetePesado.Impuestos;

            // Assert

            Assert.AreEqual(valorEsperado, valorRetornado); 
        }
    }
}
