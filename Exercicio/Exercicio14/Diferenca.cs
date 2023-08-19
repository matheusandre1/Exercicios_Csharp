using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
     class Diferenca
    {
        public int num1 { get; set; }

        public int num2 { get; set; }

        public void  exibir()
        {
            Console.Write("Insira o valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor: ");
            num2 = int.Parse(Console.ReadLine());

            CalculoDif();
            Console.ReadKey();
           
        }
        public void CalculoDif()
        {
            if (num1 > num2)
            {
                Console.WriteLine($"A Diferença dos numeros é : {num1 - num2}");
            }
            else
            {
                Console.WriteLine($"A Diferença dos numeros é : {num2 - num1}");
            }
        }
    }
}
