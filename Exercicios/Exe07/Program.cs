using System;

namespace Exe07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Temperatura em °F: ");
            float F = float.Parse(Console.ReadLine());

            float C = (F - 32) * 5 / 9;

            Console.WriteLine($"Conversão em °C : {C}");
        }
    }
}