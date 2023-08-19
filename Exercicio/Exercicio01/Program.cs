using Exercicio01;
using System;
using System.Globalization;


namespace Exercicio
{
    class Program
    {

        public static void Main(string[] args)
        {
            Peca Peca1 = new Peca();

            Console.Write("Digite a Quantidade Minima: ");
            Peca1.QuantidadeMin = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a Quantidade Máxima: ");
            Peca1.QuantidadeMax = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int estoquemedio = Peca1.CalculoEstoqueMedio();



            Console.WriteLine($"Estoque Médio: {estoquemedio}");
        }
    }
}
