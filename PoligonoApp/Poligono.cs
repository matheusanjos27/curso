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

        public Poligono(Vertice[] vertices)
        {
            if (vertices.Length < 3)
            {
                throw new Exception("Poligono possui menos de 3 vertices");
            }
        }
    }
}
