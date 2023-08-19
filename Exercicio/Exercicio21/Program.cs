using System;
namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            while (true)
            {
                Console.WriteLine("Digita o Numero:");
                Num1 = int.Parse(Console.ReadLine());

                if (Num1 >= 0)
                {
                    Console.WriteLine($"O Valor de {Num1} é Positivo");
                }
                else
                {
                    Console.WriteLine($"O Valor de {Num1} é Negativo");
                }
                Console.WriteLine();
                Console.Write("Continua a Verificação: ");

                if (Console.ReadLine().Equals("NÃO")) break;
            }
        }
    }
}