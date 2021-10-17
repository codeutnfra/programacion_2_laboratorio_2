using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            // Arrange
            const decimal valorEsperado = 105;

            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("TEST1", 100M, "test", "test", 1));
            paquetes.Add(new PaquetePesado("TEST2", 200M, "test", "test", 2));

            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            // Act
            decimal valorRetornado = gestionImpuestos.CalcularTotalImpuestosAduana();

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            // Arrange
            const decimal valorEsperado = 50;

            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("TEST1", 100M, "test", "test", 1));
            paquetes.Add(new PaquetePesado("TEST2", 200M, "test", "test", 2));

            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            // Act
            decimal valorRetornado = gestionImpuestos.CalcularTotalImpuestosAfip();

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }
    }
}
