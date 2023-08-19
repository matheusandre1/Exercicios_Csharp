using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    class Num
    {
        public int Num1 { get; set; }

        public int A { get; set; }

        public int B { get; set; }

        public void Exibir()
        {
            Console.Write("Informe o Valor");
            Num1 = int.Parse(Console.ReadLine());

            if (Num1 > 0)
            {
                A = Num1;
                Console.WriteLine($"Valor positivo de A = {A}");
            }
            else
            {
                B = Num1;
                Console.WriteLine($"Valor Negativo De B = {B}");
            }


        }
    }
}
