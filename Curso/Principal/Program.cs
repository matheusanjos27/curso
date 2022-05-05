
using IntervaloApp;
using ListaIntervaloApp;
using PiramideApp;
using PoligonoApp;
using TrianguloApp;
using VerticeApp;


// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.Clear();
    Console.WriteLine("Console principal");
    Console.WriteLine("");

    Console.WriteLine("1 - Exercicio Piramide");
    Console.WriteLine("2 - Exercicio Vertice");
    Console.WriteLine("3 - Exercicio Triangulo");
    Console.WriteLine("4 - Exercicio Poligono");
    Console.WriteLine("5 - Exercicio Intervalo");
    Console.WriteLine("6 - Exercicio Lista Intervalo");
    Console.WriteLine("7 - Exercicio Dados");
    Console.WriteLine("0 - Fechar");

    int opcao = Convert.ToInt16(Console.ReadLine());
    if (opcao == 0)
    {
        break; //encerra execucao
    }

    switch (opcao)
    {
        case 1:

            try
            {
                Console.WriteLine("Piramide");
                int altura;
                Console.Write("Digite a altura da piramide: ");
                altura = Convert.ToInt16(Console.ReadLine());
                Piramide piramide = new Piramide(altura);
                piramide.Desenha();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case 2:
            Console.WriteLine("Vertice");
            Console.WriteLine("");

            try
            {

                int x, y;
                Console.WriteLine("Primeiro vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());

                Vertice verticeA = new Vertice(x, y);

                Console.WriteLine("");
                Console.WriteLine("Segundo vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());

                Vertice verticeB = new Vertice(x, y);

                Console.WriteLine("Distancia entre os vertices: " + verticeA.Distancia(verticeB).ToString());

                if (verticeA.Igual(verticeB))
                {
                    Console.WriteLine("Os vertices sao iguais");
                }
                else
                {
                    Console.WriteLine("Os vertices sao diferentes!");
                }

                Console.WriteLine("");
                Console.WriteLine("Mova o segundo vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());

                verticeA.Move(x, y);
                Console.WriteLine("Nova distancia entre os vertices: " + verticeA.Distancia(verticeB).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case 3:
            Console.WriteLine("Triangulo");
            Console.WriteLine("");

            try
            {
                int x = 0, y = 0;

                Console.WriteLine("Primeiro Triangulo!");
                Console.WriteLine("");
                Console.WriteLine("Informe o primeiro vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());
                Vertice verticeA1 = new Vertice(x, y);

                Console.WriteLine("");
                Console.WriteLine("Informe o segundo vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());
                Vertice verticeB1 = new Vertice(x, y);

                Console.WriteLine("");
                Console.WriteLine("Informe o terceiro vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());
                Vertice verticeC1 = new Vertice(x, y);

                Triangulo trianguloA = new Triangulo(verticeA1, verticeB1, verticeC1);

                Console.WriteLine("");
                Console.WriteLine("Segundo Triangulo!");
                Console.WriteLine("");
                Console.WriteLine("Informe o primeiro vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());
                Vertice verticeA2 = new Vertice(x, y);

                Console.WriteLine("");
                Console.WriteLine("Informe o segundo vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());
                Vertice verticeB2 = new Vertice(x, y);

                Console.WriteLine("");
                Console.WriteLine("Informe o terceiro vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());
                Vertice verticeC2 = new Vertice(x, y);

                Triangulo trianguloB = new Triangulo(verticeA2, verticeB2, verticeC2);

                Console.WriteLine("");
                Console.WriteLine("");
                if (trianguloA.Igual(trianguloB))
                {
                    Console.WriteLine("Triangulo Iguais");
                }
                else
                {
                    Console.WriteLine("Triangulos diferentes");
                }
                Console.WriteLine("Perimetro A: " + trianguloA.Perimetro().ToString());
                Console.WriteLine("Tipo A: " + trianguloA.Tipo().ToString());
                Console.WriteLine("Area A: " + trianguloA.Area().ToString());
                Console.WriteLine("");

                Console.WriteLine("Perimetro B: " + trianguloB.Perimetro().ToString());
                Console.WriteLine("Tipo B: " + trianguloB.Tipo().ToString());
                Console.WriteLine("Area B: " + trianguloB.Area().ToString());
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case 4:
            Console.WriteLine("Poligono");

            try
            {
                int x, y;
                int qvertices;

                Console.Write("Informe a quantidade de vertices que deseja adicionar: ");
                qvertices = Convert.ToInt16(Console.ReadLine());

                List<Vertice> vertices = new List<Vertice>();

                for (int i = 1; i <= qvertices; i++)
                {
                    x = 0;
                    y = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Informe o {0} vertice", i);
                    Console.Write("Informe X: ");
                    x = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Informe Y: ");
                    y = Convert.ToInt16(Console.ReadLine());
                    Vertice vertice = new Vertice(x, y);

                    vertices.Add(vertice);
                }

                Poligono poligono = new Poligono(vertices);
                Console.WriteLine("");

                Console.WriteLine("Perimetro do poligono: " + poligono.Perimetro().ToString());

                Console.WriteLine("Quantidade de vertices: " + poligono.QuantidadeVertices().ToString());

                x = 0;
                y = 0;
                Console.WriteLine("");
                Console.WriteLine("Informe o novo vertice");
                Console.Write("Informe X: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Informe Y: ");
                y = Convert.ToInt16(Console.ReadLine());
                Vertice vertice2 = new Vertice(x, y);

                Console.WriteLine("");

                if (!poligono.AddVertice(vertice2))
                {
                    Console.WriteLine("Poligono ja possui esse vertice");
                }

                Console.WriteLine("");
                Console.WriteLine("Perimetro do poligono: " + poligono.Perimetro().ToString());
                Console.WriteLine("Quantidade de vertices: " + poligono.QuantidadeVertices().ToString());

                poligono.RemoveVertice(vertice2);

                Console.WriteLine("");
                Console.WriteLine("Perimetro do poligono: " + poligono.Perimetro().ToString());
                Console.WriteLine("Quantidade de vertices: " + poligono.QuantidadeVertices().ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case 5:
            Console.WriteLine("Intervalo");
            Console.WriteLine("");
            try
            {
                string? strdata;
                DateTime datainicial;
                DateTime datafinal;

                while (true)
                {
                    Console.Write("Digite a data inicial (DD/MM/AAAA) : ");
                    strdata = Console.ReadLine();

                    if (strdata == null || strdata == "")
                    {
                        Console.WriteLine("Data nao pode ser vazia");
                        continue;
                    }
                    if (!DateTime.TryParse(strdata, out datainicial))
                    {
                        Console.WriteLine("Data informada invalida");
                        continue;
                    }
                    break;
                }
                Console.WriteLine("");
                while (true)
                {
                    Console.Write("Digite a data final (DD/MM/AAAA) : ");
                    strdata = Console.ReadLine();

                    if (strdata == null || strdata == "")
                    {
                        Console.WriteLine("Data nao pode ser vazia");
                        continue;
                    }
                    if (!DateTime.TryParse(strdata, out datafinal))
                    {
                        Console.WriteLine("Data informada invalida");
                        continue;
                    }
                    break;
                }

                Intervalo intervalo = new Intervalo(datainicial, datafinal);
                Console.WriteLine("");

                Console.WriteLine("Informe um novo intervalo!");

                while (true)
                {
                    Console.Write("Digite a data inicial (DD/MM/AAAA) : ");
                    strdata = Console.ReadLine();

                    if (strdata == null || strdata == "")
                    {
                        Console.WriteLine("Data nao pode ser vazia");
                        continue;
                    }
                    if (!DateTime.TryParse(strdata, out datainicial))
                    {
                        Console.WriteLine("Data informada invalida");
                        continue;
                    }
                    break;
                }
                Console.WriteLine("");
                while (true)
                {
                    Console.Write("Digite a data final (DD/MM/AAAA) : ");
                    strdata = Console.ReadLine();

                    if (strdata == null || strdata == "")
                    {
                        Console.WriteLine("Data nao pode ser vazia");
                        continue;
                    }
                    if (!DateTime.TryParse(strdata, out datafinal))
                    {
                        Console.WriteLine("Data informada invalida");
                        continue;
                    }
                    break;
                }
                Console.WriteLine("");
                if (intervalo.Igual(datainicial, datafinal))
                {
                    Console.WriteLine("O intervalo e igual!");
                }
                else
                {
                    Console.WriteLine("O intervalo e diferente!");
                }

                Console.WriteLine("");
                if (intervalo.TemIntersecao(datainicial, datafinal))
                {
                    Console.WriteLine("As datas possuem intersecao!");
                }
                else
                {
                    Console.WriteLine("As datas nao possuem intersecao!");
                }

                Console.WriteLine("");
                Console.WriteLine("Total de dias no intervalo: " + intervalo.Duracao.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case 6:
            Console.WriteLine("Lista Intervalo");
            Console.WriteLine("");

            try
            {
                ListaIntervalo intervalos = new ListaIntervalo();

                int qtdintervalo;

                Console.Write("Informe a quantidade de intervalos que deseja adicionar: ");
                qtdintervalo = Convert.ToInt16(Console.ReadLine());

                for (int i = 1; i <= qtdintervalo; i++)
                {
                    string? strdata;
                    DateTime datainicial;
                    DateTime datafinal;

                    while (true)
                    {
                        Console.Write("Digite a data inicial (DD/MM/AAAA) : ");
                        strdata = Console.ReadLine();

                        if (strdata == null || strdata == "")
                        {
                            Console.WriteLine("Data nao pode ser vazia");
                            continue;
                        }
                        if (!DateTime.TryParse(strdata, out datainicial))
                        {
                            Console.WriteLine("Data informada invalida");
                            continue;
                        }
                        break;
                    }
                    Console.WriteLine("");
                    while (true)
                    {
                        Console.Write("Digite a data final (DD/MM/AAAA) : ");
                        strdata = Console.ReadLine();

                        if (strdata == null || strdata == "")
                        {
                            Console.WriteLine("Data nao pode ser vazia");
                            continue;
                        }
                        if (!DateTime.TryParse(strdata, out datafinal))
                        {
                            Console.WriteLine("Data informada invalida");
                            continue;
                        }
                        Console.WriteLine("");
                        break;
                    }

                    Intervalo intervalo = new Intervalo(datainicial, datafinal);

                    intervalos.Add(intervalo);
                }

                intervalos.Imprime();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("");
            break;

        case 7:
            Console.WriteLine("Dados");
            Console.WriteLine("");
            try
            {
                DadosApp.Dados();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }
    Console.WriteLine("");
    Console.WriteLine("Pressione qualquer tecla para continuar!");
    Console.ReadKey();
}