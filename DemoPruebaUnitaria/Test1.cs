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

        [TestMethod]
        public void PerimetroCuadrado()
        {
            var Cuadrado = new Cuadrado(5);
            var resultado = Cuadrado.perimetro();
            Assert.AreEqual(20, resultado);
        }
    }

    [TestClass]
    public sealed class TestUnitRectangulo
    {
        [TestMethod]
        public void AreaRectangulo()
        {
            var Rectangulo = new Rectangulo(5, 3);
            var resultado = Rectangulo.area();
            Assert.AreEqual(15, resultado);
        }

        [TestMethod]
        public void PerimetroRectangulo()
        {
            var Rectangulo = new Rectangulo(5, 3);
            var resultado = Rectangulo.perimetro();
            Assert.AreEqual(16, resultado);
        }
    }
}

    
