// See https://aka.ms/new-console-template for more information
using PoligonoApp;
using VerticeApp;

Console.WriteLine("Poligono");

try
{

    Vertice verticeA2 = new Vertice(15, 1);
    Vertice verticeB2 = new Vertice(2, 2);
    Vertice verticeC2 = new Vertice(3, 9);

    Vertice[] vertices = { verticeA2, verticeB2 };

    Poligono trianguloB = new Poligono(vertices);


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}