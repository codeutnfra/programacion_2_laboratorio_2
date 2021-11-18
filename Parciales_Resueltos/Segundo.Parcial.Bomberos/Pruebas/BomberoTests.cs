using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class BomberoTests
    {
        [TestMethod]
        public void Leer_DeberiaRetornarElBomberoSerializado()
        {
            // Arrange
            Bombero bombero = new Bombero("Prueba");
            
            // Act
            bombero.Guardar(bombero);

            // Assert
            Bombero bomberoDeserializado = bombero.Leer();
            Assert.AreEqual(bombero.Nombre, bomberoDeserializado.Nombre);
        }
    }
}
