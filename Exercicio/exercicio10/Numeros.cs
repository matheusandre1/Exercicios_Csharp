using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Numeros
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public void Exibir()
        {
            Console.Write("Primeiro Valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            num2 = int.Parse(Console.ReadLine());

                
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} é igual {num2}");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"{num1} é Maior que {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} é Menor que {num2}  ");
            }
            else if (num1 >= num2)
            {
                Console.WriteLine($"{num1} é igual ou maior que {num2}");
            }
            else if (num1 <= num2)
            {
                Console.WriteLine($"{num1} é igual menor que {num2}");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
