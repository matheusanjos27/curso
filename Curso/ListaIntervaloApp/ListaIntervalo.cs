using IntervaloApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIntervaloApp
{
    public class ListaIntervalo
    {
        private List<Intervalo> intervalos;
        public List<Intervalo> Intervalos { get { return intervalos; }}

        public ListaIntervalo()
        {
            intervalos = new List<Intervalo>(); 
        }

        public void Add(Intervalo intervalo)
        {
            bool temIntersecao = false;
            foreach(Intervalo interval in intervalos)
            {
                temIntersecao = interval.TemIntersecao(intervalo.DataInicial, intervalo.DataFinal);
                if (temIntersecao)
                {
                    break;
                }
            }
            if (!temIntersecao)
            {
                intervalos.Add(intervalo);
            }
        }
        public void Imprime()
        {
            if (intervalos.Count == 0)
            {
                Console.WriteLine("Nao existem dados para impressao");
                return;
            }
            var _intervalos = intervalos.OrderBy(o => o.DataInicial).ToList();

            foreach (Intervalo intervalo in _intervalos)
            {
                Console.Write("Data inicial: " + intervalo.DataInicial.ToShortDateString());
                Console.Write("   Data final: " + intervalo.DataFinal.ToShortDateString());
                Console.WriteLine("");
            }
        }
    }
}
