using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Numeros
    {
        public int num1 { get; set; }

        public void Exibir()
        {
            Console.Write("Insira um Valor: ");
            num1 = int.Parse(Console.ReadLine());
            Verificacao();
        }

        public void Verificacao()
        {
            if (num1 >= 0 && num1 <= 9)
            {
                Console.WriteLine("Valor Válido!");
            }
            else
            {
                Console.WriteLine("Valor Inválido!");
            }
        }
    }
}
