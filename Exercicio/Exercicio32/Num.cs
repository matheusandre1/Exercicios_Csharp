using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio32
{
    internal class Num
    {
        public int Num1 { get; set; }

        public int Maior { get; set;}

        public int Menor { get; set;}

        public void Exibicao()
        {
            Entrada();
            VerificarCondicao();
            
            



           


          


        }

        public void Entrada()
        {
            Console.Write("Digite o Numero: ");
            Num1 = int.Parse(Console.ReadLine());
        }       

        public void VerificarCondicao()
        {
            if (Num1 >= 0 )
            {
                Maior = Num1;
                Menor = Num1;
                while (Num1 != 0)
                {
                    Console.Write("Digite o Numero: ");
                    Num1 = int.Parse(Console.ReadLine());
                    if (Num1 > Maior)
                    {
                        Maior = Num1;
                    }
                    else
                    {
                        Menor = Num1;
                    }


                }
                Console.WriteLine($"Maior foi {Maior} e o Menor foi {Menor}");
            } 
        }


    }
}
