using System;

namespace Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Valor que US$: ");
            double dolar  = double.Parse(Console.ReadLine());

            double resultado = cotacao * dolar;
            Console.WriteLine($"Valor em real é {resultado.ToString("C")}");
            
        }
    }
}