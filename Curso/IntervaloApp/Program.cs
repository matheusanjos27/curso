// See https://aka.ms/new-console-template for more information
using IntervaloApp;

try
{
    Intervalo intervalo = new Intervalo(new DateTime(1999, 05, 25), new DateTime(1999, 5, 26));
    Console.WriteLine("");

    DateTime datainicial = new DateTime(1999, 05, 25);
    DateTime datafinal = new DateTime(1999, 05, 28);

    if (intervalo.Igual(datainicial, datafinal))
    {
        Console.WriteLine("As datas são iguais!");
    }
    else
    {
        Console.WriteLine("As datas são diferentes!");
    }

    datainicial = new DateTime(1999, 05,22);
    datafinal = new DateTime(1999, 05, 28);

    if (intervalo.TemIntersecao(datainicial, datafinal))
    {
        Console.WriteLine("1- As datas possuem intersecao!");
    }

    datainicial = new DateTime(1999, 05, 27);
    datafinal = new DateTime(1999, 06, 05);

    if (intervalo.TemIntersecao(datainicial, datafinal))
    {
        Console.WriteLine("2- As datas possuem intersecao!");
    }

    datainicial = new DateTime(1999, 05, 22);
    datafinal = new DateTime(1999, 06, 05);

    if (intervalo.TemIntersecao(datainicial, datafinal))
    {
        Console.WriteLine("3- As datas possuem intersecao!");
    }

    datainicial = new DateTime(1999, 05, 27);
    datafinal = new DateTime(1999, 05, 29);

    if (intervalo.TemIntersecao(datainicial, datafinal))
    {
        Console.WriteLine("4- As datas possuem intersecao!");
    }

    datainicial = new DateTime(1999, 06, 01);
    datafinal = new DateTime(1999, 06, 10);

    if (!intervalo.TemIntersecao(datainicial, datafinal))
    {
        Console.WriteLine("As datas nao possuem intersecao!");
    }

    Console.WriteLine("Total de dias no intervalo: "+intervalo.Duracao.ToString());



}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
