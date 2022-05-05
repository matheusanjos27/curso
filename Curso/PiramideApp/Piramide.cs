using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideApp
{
    public class Piramide
    {
        public int N { get; set; }

        public Piramide(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Valor deve ser maior que 0");
            }
            N = valor;
        }

        public void Desenha()
        {
            int n = this.N, esp = 1, num = 1;

            for (int i = 1; i <= n; i++)
            {
                for (esp = 1; esp <= (n - i); esp++)
                    Console.Write(" ");

                for (num = 1; num <= i; num++)
                    Console.Write(num);

                for (num = (i - 1); num >= 1; num--)
                    Console.Write(num);

                Console.WriteLine();
            }

        }

    }

}

