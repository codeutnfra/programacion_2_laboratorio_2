using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            // Arrange
            PaqueteFragil paqueteFragil = new PaqueteFragil("test", 1, "test", "test", 1);

            // Act
            bool valorRetornado = paqueteFragil.TienePrioridad;

            // Assert
            Assert.IsTrue(valorRetornado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            // Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 35;

            PaqueteFragil paqueteFragil = new PaqueteFragil("test", costoEnvio, "test", "test", 1);

            // Act
            decimal valorRetornado = paqueteFragil.Impuestos;

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            // Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 135;

            PaqueteFragil paqueteFragil = new PaqueteFragil("test", costoEnvio, "test", "test", 1);

            // Act
            decimal valorRetornado = paqueteFragil.AplicarImpuestos();

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }
    }
}
