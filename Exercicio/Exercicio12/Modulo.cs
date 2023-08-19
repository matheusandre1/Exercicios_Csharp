using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Modulo
    {
        public int numX { get; set; }

        int modulo;

        public void Exibir()
        {
            Console.Write("Insira um valor para X: ");
            numX = int.Parse(Console.ReadLine());

            if (numX <= 0)
            {
                modulo = numX * (-1);
            }
            else
            {
                modulo = numX;
            }

            Console.WriteLine($"O Modulo de {numX} é: {modulo} ");
            Console.ReadKey();
        }
    }
}
