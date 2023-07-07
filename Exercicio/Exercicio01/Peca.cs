using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
     class Peca
    {
        public int QuantidadeMax { get; set; }

        public int QuantidadeMin { get; set; }


        public int CalculoEstoqueMedio()
        {
            return (QuantidadeMax + QuantidadeMin) / 2;
        }
    }
}
