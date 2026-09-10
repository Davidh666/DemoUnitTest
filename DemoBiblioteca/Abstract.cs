using System;
using System.Collections.Generic;
using System.Text;

namespace DemoBiblioteca
{
    public abstract class Figura
    {
        public abstract decimal area();
        public abstract decimal perimetro();
    }
    public class Cuadrado : Figura
    {
        public readonly decimal lado;

        public Cuadrado(decimal lado) { this.lado = lado; }

        public override decimal area()
        {
            return lado * lado;
        }
        public override decimal perimetro()
        {
            return lado * 4;
        }
    }
    public class Rectangulo : Figura
    {
        public readonly decimal baseRect;
        public readonly decimal altura;

        public Rectangulo(decimal baseRect, decimal altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        public override decimal area()
        {
            return baseRect * altura;
        }
        public override decimal perimetro()
        {
            return 2 * (baseRect + altura);
        }
    }
    public class Circulo : Figura
    {
        public readonly decimal radio;

        public Circulo(decimal radio)
        {
            this.radio = radio;
        }

        public override decimal area()
        {
            return (decimal)Math.PI * radio * radio;
        }

        public override decimal perimetro()
        {
            return 2m * (decimal)Math.PI * radio;
        }
    }
}