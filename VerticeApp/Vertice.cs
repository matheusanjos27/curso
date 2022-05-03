using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerticeApp
{
    public class Vertice
    {
        private double x;
        public double X { get { return x; } }

        private double y;
        public double Y { get { return y; } }

        public Vertice(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public double Distancia(Vertice vertice)
        {
            double distancia = Math.Sqrt(Math.Pow(vertice.X - this.X, 2) + Math.Pow(vertice.Y - this.Y, 2));
            return distancia;
        }

        public void Move(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public bool Igual(Vertice vertice)
        {
            return (this.X == vertice.X && this.Y == vertice.Y);
        }

    }
}
