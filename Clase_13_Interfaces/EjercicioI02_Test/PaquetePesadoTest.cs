using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioI02_Biblioteca;

namespace EjercicioI02_Test
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAfipYAduana()
        {

        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {

        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {

        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse() 
        {
            // Arrange 

            PaquetePesado paquetePesado = new PaquetePesado(string.Empty, 0, string.Empty, string.Empty, 0);

            // Act 

            bool restultado = paquetePesado.TienePrioridad;

            // Assert 

            Assert.IsFalse(restultado);
        }
    }
}
