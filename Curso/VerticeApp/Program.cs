// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vertice");

try
{
    VerticeApp.Vertice verticeA = new VerticeApp.Vertice(10, 8);
    VerticeApp.Vertice verticeB = new VerticeApp.Vertice(8, 6);

    Console.WriteLine("Distancia entre os vertices: " + verticeA.Distancia(verticeB).ToString());

    verticeA.Move(8, 6);
    Console.WriteLine("Distancia entre os vertices: " + verticeA.Distancia(verticeB).ToString());

    if (verticeA.Igual(verticeB))
    {
        Console.WriteLine("Vertices sao iguais");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
