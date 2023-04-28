using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
     class CotaDolar
    {
        public double Dolar { get; set; }
        public double Cotacao { get; set;}

        public double ConverterPraReal()
        {
            return Dolar * Cotacao;
        }
    }
}
