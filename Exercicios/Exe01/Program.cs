using System;

namespace Exe01
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Quantidade Minima: ");
            int quantiMin = int.Parse(Console.ReadLine());
            Console.Write("Quantidade Máxima: ");
            int quantiMax = int.Parse(Console.ReadLine());

            int estoqueMedio = (quantiMin + quantiMax) / 2;
            Console.WriteLine($"O Estoque médio é : {estoqueMedio}");
            Console.Clear();
        }
    }
}