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
    public class Rentangulo : Figura
    {
        public readonly decimal lado;

        public Rentangulo(decimal lado) => this.lado = lado;

        public override decimal area()
        {
            throw new NotImplementedException();
        }
        public override decimal perimetro()
        {
            throw new NotImplementedException();
        }
    }
}
