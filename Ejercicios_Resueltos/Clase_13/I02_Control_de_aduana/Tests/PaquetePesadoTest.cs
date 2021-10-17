using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PaquetePesadoTest
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
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 35;

            PaquetePesado paquetePesado = new PaquetePesado("test", costoEnvio, "test", "test", 1);

            // Act
            decimal valorRetornado = paquetePesado.Impuestos;

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip()
        {
            // Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 25;

            PaquetePesado paquetePesado = new PaquetePesado("test", costoEnvio, "test", "test", 1);

            // Act
            decimal valorRetornado = ((IAfip)paquetePesado).Impuestos;

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            // Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 160;

            PaquetePesado paquetePesado = new PaquetePesado("test", costoEnvio, "test", "test", 1);

            // Act
            decimal valorRetornado = paquetePesado.AplicarImpuestos();

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }
    }
}
