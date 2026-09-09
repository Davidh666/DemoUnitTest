using DemoBiblioteca;

namespace DemoPruebaUnitaria
{
    [TestClass]
    public sealed class TesTestUnitCuadrado
    {
        [TestMethod]
        public void AreaCuadrado()
        {
            var Cuadrado = new Cuadrado(5);
            var resultado = Cuadrado.area();
            Assert.AreEqual(25, resultado);
        }
    }

    [TestClass]
    public sealed class TestUnitRectangulo
    {
        [TestMethod]
        public void Rectangulo()
        {

        }
    }
}

