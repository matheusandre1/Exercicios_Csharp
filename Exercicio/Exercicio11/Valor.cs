using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Valor
    {

        public int A { get; set; }
        public int B { get; set; }
        int X { get; set; }
        public void Exibir()
        {
            Console.WriteLine("Insira o Valor : ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Valor : ");
            B = int.Parse(Console.ReadLine());

            X = A;
            A = B;
            B = X;

            Console.WriteLine($"A: {A} ");
            Console.WriteLine($"B: {B}");

            Console.ReadKey();
        }

    }
}
