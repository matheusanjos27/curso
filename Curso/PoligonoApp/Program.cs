// See https://aka.ms/new-console-template for more information
using PoligonoApp;
using VerticeApp;

Console.WriteLine("Poligono");

try
{

    Vertice verticeA2 = new Vertice(15, 1);
    Vertice verticeB2 = new Vertice(2, 2);
    Vertice verticeC2 = new Vertice(3, 9);

    List<Vertice> vertices = new List<Vertice>() { verticeA2, verticeB2, verticeC2 };

    Poligono poligonoA = new Poligono(vertices);

    if (!poligonoA.AddVertice(new Vertice(10, 13)))
    {
        Console.WriteLine("Poligono ja possui esse vertice");
    }

    if (!poligonoA.AddVertice(verticeA2))
    {
        Console.WriteLine("Poligono ja possui esse vertice");
    }

    poligonoA.RemoveVertice(verticeA2);
    poligonoA.RemoveVertice(verticeB2);

    Console.WriteLine(poligonoA.Perimetro());

    Console.WriteLine(poligonoA.QuantidadeVertices());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}