using System;
using System.Globalization;

namespace Exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tempo Gasto: ");
            double tempoGasto = int.Parse(Console.ReadLine()!);

            Console.Write("Velocidade Média: ");
            double VM = int.Parse(Console.ReadLine()!);

            double distanciaPecorrida = tempoGasto * VM;
            double quantidadeLitroCombustivel = distanciaPecorrida / 12;


            Console.WriteLine($"Velocidade Média: {VM} KM/H");
            Console.WriteLine($"Tempo Gasto: {tempoGasto} H");
            Console.WriteLine($"Distância Percorrida: {distanciaPecorrida} km");
            Console.WriteLine($"Quantidade de Litros de Combustivel: {quantidadeLitroCombustivel.ToString("F")} L");
        }
    }
}