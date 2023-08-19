using System;

namespace Exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero Da Tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int x = numero; x <= numero; x++)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($" {x} X {i} = {x * i}");
                }
            }
        }
    }
}
