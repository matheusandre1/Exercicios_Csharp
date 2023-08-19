using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio30
{
    internal class NumInt
    {
        public int Num1 { get; set; }

        public int Resultado { get; set; }

        public bool condicaoverificada;
        public void Exibir()
        {

            do
            {
                Console.WriteLine("Digite o Numero de 1 a 10");
                Num1 = int.Parse(Console.ReadLine());
               
            } while (Num1 >= 0 || Num1 <= 10);

            for (int x = Num1; x < 40 + Num1; x++)
            {
                if (x % 2 == 1)
                {
                    Resultado += x * x;
                }

            }

            Console.WriteLine($"O resultado da soma do numero informado é: {Resultado}");



}

        
    }
}
