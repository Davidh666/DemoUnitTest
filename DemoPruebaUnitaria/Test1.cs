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

    [TestClass]
    public class TestUnitCirculo
    {
        [TestMethod]
        public void Test_Area_Circulo()
        {
            decimal radio = 3m;
            Circulo circulo = new Circulo(radio);
            decimal areaEsperada = (decimal)Math.PI * 9m;
            decimal resultado = circulo.area();
            Assert.AreEqual(Math.Round(areaEsperada, 4), Math.Round(resultado, 4), "El área calculada no es correcta.");
        }

        [TestMethod]
        public void Test_Perimetro_Circulo()
        {
            decimal radio = 5m;
            Circulo circulo = new Circulo(radio);
            decimal perimetroEsperado = 2m * (decimal)Math.PI * 5m;
            decimal resultado = circulo.perimetro();
            Assert.AreEqual(Math.Round(perimetroEsperado, 4), Math.Round(resultado, 4), "El perímetro calculado no es correcto.");
        }
    }
}