using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Numeros numeros = new Numeros();
            numeros.EntradaDeValores();
            numeros.SomadeValores();
            numeros.MultiplicacaodosValores();
        }
    }
}
