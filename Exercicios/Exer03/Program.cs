using System;

namespace Exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo! insira seu nome completo:");
            string vendedor = Console.ReadLine();

            Console.WriteLine("Insira o codigo do produto:");
            int cod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o preço unitario:");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade vendida:");
            int qtd = Convert.ToInt32(Console.ReadLine());

            double venda = qtd * preco;
            double comissao = venda * 0.05;

            Console.WriteLine($"Vendedor:" + vendedor);
            Console.WriteLine($"Cod.Produto:" + cod);
            Console.WriteLine($"Preço:" + preco);
            Console.WriteLine($"Qtd.Vendida:" + qtd);
            Console.WriteLine($"Total:" + venda);
            Console.WriteLine($"Comissão:" + comissao);

        }
    }
}