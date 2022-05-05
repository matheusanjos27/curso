using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerticeApp;

namespace PoligonoApp
{
    public class Poligono
    {
        private List<Vertice> vertices;

        public List<Vertice> Vertices { get { return vertices; } }

        public Poligono()
        {
            vertices = new List<Vertice>();
        }

        public Poligono(List<Vertice> _vertices)
        {
            if (_vertices.Count < 3)
            {
                throw new Exception("Poligono possui menos de 3 vertices");
            }
            vertices = _vertices;
        }

        public bool AddVertice(Vertice _vertice)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                if (vertices[i].Igual(_vertice))
                    return false;
            }
            vertices.Add(_vertice);
            return true;
        }

        public void RemoveVertice(Vertice _vertice)
        {
            Vertice v = new Vertice();
            foreach (Vertice _v in Vertices)
            {
                if (_v.Igual(_vertice))
                {
                    v = _v;
                    break;
                }
            }

            vertices.Remove(v);

            if (vertices.Count < 3)
            {
                throw new Exception("Poligono ficará com menos de 3 vertices");
            }
        }

        public double Perimetro()
        {
            List<double> lados = new List<double>();
            double lado = 0;

            for (int i = 0; i < vertices.Count; i++)
            {
                if (i < vertices.Count - 1)
                {
                    lado += vertices[i].Distancia(vertices[i + 1]);
                }
                else
                {
                    lado += vertices[i].Distancia(vertices[0]);
                }
            }

            return (lado);
        }

        public int QuantidadeVertices()
        {
            return vertices.Count;
        }
    }
}
