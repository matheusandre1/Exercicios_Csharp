using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercicio03
{
     class Vendedor
    {
        double totalvenda, comissao;
        public string Nome { get; set; }

        public int  Cod { get; set;}

        public  double  QuantidadeVendida { get; set; }

        public double Comissao { get; set; }

        public  double PrecoUnitario { get; set; }


        public void  IdentificacaoVendedor()
        {
            Console.Clear();
            Console.Write("Insira seu nome completo: ");
            Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Insira o Código Do Produto : ");
            Cod = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Insira o Preço Unitário: ");
            PrecoUnitario = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Quantidade Vendida : ");
            QuantidadeVendida = double.Parse(Console.ReadLine());

            totalvenda = Venda();

            comissao = CalculoComissao(totalvenda);

            Console.WriteLine($"Identificação do Vendedor: {Nome}");
            Console.WriteLine($"Código da Peça:  {Cod}");
            Console.WriteLine($"Preço Unitário: {PrecoUnitario}");
            Console.WriteLine($"Quantidade Vendida : {QuantidadeVendida}");
            Console.WriteLine($"Total de venda {totalvenda}");
            Console.WriteLine($"Comissão: {comissao}");


        }

        public double  Venda()
        {
            return QuantidadeVendida * PrecoUnitario;
        }

        public double CalculoComissao(double totalvenda)
        {
            return totalvenda * 0.05;
        }
    }
}
