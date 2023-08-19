using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercicio16
{
    class Numeros
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public void Exibir()
        {
            Console.Write("Insira o 1° Valor: ");
            Num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o 2° Valor: ");
            Num2 = int.Parse(Console.ReadLine());

            Verificacao();
        }

        public void Verificacao()
        {
            if (Num1 > Num2)
            {
                Console.WriteLine($"{Num1} é Maior que {Num2}");
            }

            else if (Num2 < Num1)
            {
                Console.WriteLine($"{Num2} é Maior que {Num1}");
            }

            else if (Num1 == Num2)
            {
                Console.WriteLine($"{Num1} e o valor {Num2} são iguais.");
            }
        }
    }

}


