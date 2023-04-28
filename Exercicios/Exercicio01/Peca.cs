using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
     class Peca
    {
        public int QuantidaMaxima { get; set; }

        public int QuantidadeMinima { get; set; }

        public int EstoqueMedio()
        {
            return (QuantidadeMinima + QuantidaMaxima)/2;
        }
    }
}
