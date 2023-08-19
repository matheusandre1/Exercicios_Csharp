using System;

namespace Exercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            for ( num = 0; num <= 100; num++)
            {
                if (num % 10 == 0)
                {
                    Console.WriteLine($"{num} é Multiplo de 10");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadKey();
        }
    }
}