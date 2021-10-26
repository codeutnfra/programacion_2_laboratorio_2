using IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PuntoXmlTest
    {
        [TestMethod]
        public void ValidarExtension_RetornaTrue_CuandoLaExtensionEsXml()
        {
            // Arrange
            PuntoXml<string> puntoXml = new PuntoXml<string>();

            // Act
            bool retorno = puntoXml.ValidarExtension("archivo.xml");

            // Assert
            Assert.IsTrue(retorno);
        }


        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_LanzaArchivoInvalidoException_CuandoLaExtensionNoEsXml()
        {
            // Arrange
            PuntoXml<string> puntoXml = new PuntoXml<string>();

            // Act
            bool retorno = puntoXml.ValidarExtension("archivo.bin");
        }
    }
}
