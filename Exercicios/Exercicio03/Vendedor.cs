using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Vendedor
    {
        double comissao;
        double venda;
        public string NomeVendedor { get; set; }

        public int CodProduto { get; set; }

        public int QuantidadeVendida { get; set; }

        public double Preco { get; set; }


        public double CalcularVenda()
        {
            return venda = QuantidadeVendida * Preco;
        }
        public double CalcularComissao()
        {
            return comissao =venda * 0.05; 
        }



    }
}
