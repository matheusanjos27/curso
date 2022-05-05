// See https://aka.ms/new-console-template for more information
using IntervaloApp;
using ListaIntervaloApp;

Console.WriteLine("Lista Intervalo");

ListaIntervalo intervalos = new ListaIntervalo();

Intervalo intervalo1 = new Intervalo(new DateTime(1999, 05, 25), new DateTime(1999, 5, 26));
intervalos.Add(intervalo1);

intervalos.Add(intervalo1);

intervalo1 = new Intervalo(new DateTime(1999, 06, 25), new DateTime(1999, 06, 26));
intervalos.Add(intervalo1);

intervalo1 = new Intervalo(new DateTime(1999, 07, 25), new DateTime(1999, 07, 26));
intervalos.Add(intervalo1);

intervalo1 = new Intervalo(new DateTime(1999, 05, 20), new DateTime(1999, 5, 27));
intervalos.Add(intervalo1);

intervalos.Imprime();