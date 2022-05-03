// See https://aka.ms/new-console-template for more information
using TrianguloApp;
using VerticeApp;

Console.WriteLine("Triangulo");

try
{
    Vertice verticeA1 = new Vertice(-1, 1);
    Vertice verticeB1 = new Vertice(3, 1);
    Vertice verticeC1 = new Vertice(1, 3);

    Triangulo trianguloA = new Triangulo(verticeA1, verticeB1, verticeC1);

    Vertice verticeA2 = new Vertice(15, 1);
    Vertice verticeB2 = new Vertice(2, 2);
    Vertice verticeC2 = new Vertice(3, 9);

    Triangulo trianguloB = new Triangulo(verticeA2, verticeB2, verticeC2);

    if (trianguloA.Igual(trianguloB))
    {
        Console.WriteLine("Triangulo Iguais");
    }

   // Console.WriteLine("Lados A: " + trianguloA.ladoA.ToString() + " , " + trianguloA.ladoB.ToString() + " , " + trianguloA.ladoC.ToString());
    Console.WriteLine("Perimetro A: " + trianguloA.Perimetro().ToString());
    Console.WriteLine("Tipo A: " + trianguloA.Tipo().ToString());
    Console.WriteLine("Area A: " + trianguloA.Area().ToString());
    Console.WriteLine("");

    //Console.WriteLine("Lados A: " + trianguloB.ladoA.ToString() + " , " + trianguloB.ladoB.ToString() + " , " + trianguloB.ladoC.ToString());
    Console.WriteLine("Perimetro B: " + trianguloB.Perimetro().ToString());
    Console.WriteLine("Tipo B: " + trianguloB.Tipo().ToString());
    Console.WriteLine("Area B: " + trianguloB.Area().ToString());
    Console.WriteLine("");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
