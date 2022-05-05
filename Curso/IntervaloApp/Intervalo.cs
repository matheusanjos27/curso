using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervaloApp
{
    public class Intervalo
    {
        private DateTime datainicial;
        public DateTime DataInicial { get { return datainicial; } }

        private DateTime datafinal;
        public DateTime DataFinal { get { return datafinal; } }

        public double Duracao { get {
                TimeSpan retorno = datafinal - datainicial;

                return retorno.TotalDays;
            } }

        public Intervalo(DateTime _datainicial, DateTime _datafinal)
        {
            datainicial = _datainicial;

            datafinal = _datafinal;

            if (DataInicial.CompareTo(DataFinal) > 0)
            {
                throw new Exception("Data incial nao pode ser maior que data final!");
            }
        }

        public bool TemIntersecao(DateTime _datainicial, DateTime _datafinal)
        {

            if (_datainicial <= this.datainicial && (_datafinal > this.datainicial && _datafinal < this.datafinal))
            {
                return true;
            }
            else if ((_datainicial > this.datainicial && _datainicial < this.datafinal) && _datafinal >= this.datafinal)
            {
                return true;
            }
            else if (_datainicial < this.datainicial && _datafinal > this.datafinal)
            {
                return true;
            }
            else if (_datainicial > this.datainicial && _datafinal < this.datafinal)
            {
                return true;
            }
            else if(this.Igual(_datainicial, _datafinal))
            {
                return true;
            }

            return false;
        }

        public bool Igual(DateTime _datainicial, DateTime _datafinal)
        {
            return (datainicial.CompareTo(_datainicial) == 0 && datafinal.CompareTo(_datafinal) == 0);
        }
    }
}
