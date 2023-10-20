using System;
using System.Net.Http.Headers;

namespace Exercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            int media;
            int[] numerointeiros = new int[10];

            Console.WriteLine("Digite 10 Valores!");
            
            for (int i = 0; i < 10;  i++)
            {
                Console.WriteLine($"Digite o { i + 1 }° Numero: )");
                numerointeiros[i] = int.Parse(Console.ReadLine());
                media += numerointeiros[i];
            }
        }
    }
}