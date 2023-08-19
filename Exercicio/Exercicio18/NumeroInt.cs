using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class NumeroInt
    {
        public int codigo { get; set; }

        public void Verificacao()
        {
            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Código Valido!");
                    Console.WriteLine($"Código {codigo} é UM");
                    break;
                case 2:
                    Console.WriteLine("Código Valido!");
                    Console.WriteLine($"Código {codigo} é DOIS");
                    break;
                case 3:
                    Console.WriteLine("Código Valido!");
                    Console.WriteLine($"Código {codigo} é TRÊS");
                    break;
                default:
                    Console.WriteLine("Código Inválido!!!!");
                    break;


            }
        }

        public void Exibir()
        {
            Console.Write("Insira o Valor: ");
            codigo = int.Parse(Console.ReadLine());

            Verificacao();
            
        }
    }
}
