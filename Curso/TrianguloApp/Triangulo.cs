using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerticeApp;

namespace TrianguloApp
{
    public enum TipoTriangulo { Invalido, Equilatero, Isosceles, Escaleno };

    public class Triangulo
    {
        private Vertice verticeA;

        public Vertice VerticeA
        {
            get { return verticeA; }
        }

        private Vertice verticeB;

        public Vertice VerticeB
        {
            get { return verticeB; }
        }

        private Vertice verticeC;

        public Vertice VerticeC
        {
            get { return verticeC; }
        }

        //Distância dos vertices (x1,y1/x2,y2/x3,y3)
        public double ladoA { get { return verticeA.Distancia(verticeB); } }
        public double ladoB { get { return verticeB.Distancia(verticeC); } }
        public double ladoC { get { return verticeC.Distancia(verticeA); } }

        public Triangulo(Vertice _verticeA, Vertice _verticeB, Vertice _verticeC)
        {
            verticeA = _verticeA;
            verticeB = _verticeB;
            verticeC = _verticeC;

            if (this.Tipo() == TipoTriangulo.Invalido)
            {
                throw new Exception("Triangulo Invalido");
            }
        }

        public double Perimetro() //P = soma da distância de todos os lados
        {
            return (ladoA + ladoB + ladoC);
        }

        public double Area()
        {
            double perimetro = this.Perimetro() / 2.0;
            return Math.Sqrt(perimetro * (perimetro - ladoA) * (perimetro - ladoB) * (perimetro - ladoC));
        }

        public TipoTriangulo Tipo()
        {
            if (ladoA == 0 & ladoB == 0 & ladoC == 0)
            {
                return TipoTriangulo.Invalido;
            }
            else if (ladoA == ladoB & ladoC == ladoA & ladoB == ladoC) //Todos os lados iguais = equilatero
            {
                return TipoTriangulo.Equilatero;
            }
            else if (ladoA != ladoB & ladoA != ladoC & ladoB != ladoC) //Todos os lados diferentes = escaleno
            {
                return TipoTriangulo.Escaleno;
            }
            else if ((ladoA == ladoB & ladoB != ladoC) ||
                     (ladoB == ladoC & ladoC != ladoA) ||
                     (ladoC == ladoA & ladoA != ladoB)) //dois lados iguais e um diferente = isoceles
            {
                return TipoTriangulo.Isosceles;
            }
            else
            {
                return TipoTriangulo.Invalido;
            }
        }

        public bool Igual(Triangulo triangulo)
        {
            return (this.Area() == triangulo.Area() && this.Perimetro() == triangulo.Perimetro());
        }
    }
}

