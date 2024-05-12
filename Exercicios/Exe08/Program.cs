using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace Exe08
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Volume da Late de Oleo");
            Console.Write("Volume: ");
            double volume = double.Parse(Console.ReadLine());
            Console.Write("Raio: ");
            double raio = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine());

            double formula = 3.14159 * raio * raio * altura;

            Console.WriteLine($"Voluma da Lata é : {formula}");
        }
    }
}