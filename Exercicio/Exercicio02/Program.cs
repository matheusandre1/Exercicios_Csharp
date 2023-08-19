using Exercicio02;
using System;
using System.Globalization;

namespace Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor cotacaodolar = new Conversor();
            Console.Write("Digite a Cotação do Dolar: ");
            cotacaodolar.Cotacao = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor em R$ que queria Converter: ");
            cotacaodolar.Dolar = double.Parse(Console.ReadLine());

            double Valoremreal = cotacaodolar.Conversao();

            Console.WriteLine($"Valor em Dolar é {Valoremreal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
