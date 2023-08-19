using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercicio15
{
    class NotaEscolar
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public double Media { get; set; }

        public double Notarecuperacao { get; set; }

        public double Mediafinal { get; set; }

        public double Mediarecuperacao { get; set; }


        public void Exibicao()
        {
            Console.WriteLine("Notas Escolares");
            Console.Write("Insira A Primeira Nota: ");
            Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Insira A Segunda Nota: ");
            Nota2 = double.Parse(Console.ReadLine());

            Console.Write("Insira A Terceira Nota: ");
            Nota3 = double.Parse(Console.ReadLine());

            Console.Write("Insira A Quarta Nota : ");
            Nota4 = double.Parse(Console.ReadLine());

            CalculoMédia();


        }

        public void CalculoMédia()
        {
            Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            if (Media >= 7)
            {
                Console.WriteLine($"Aprovado sua média final foi {Media}");
            }
            else
            {
                Console.WriteLine($"Aluno em Recuperação!");
                Console.WriteLine($"Nota Final: {Media}");
                Console.Write("Insira sua nova de recuperação:");
                Notarecuperacao = double.Parse(Console.ReadLine());

                Mediarecuperacao = Media + Notarecuperacao;

                if (Mediarecuperacao >= 7)
                {
                    Console.WriteLine("Aluno Aprovado!");
                    Console.WriteLine($"Média :{Mediarecuperacao}");

                }
                else
                {
                    Console.WriteLine("Aluno Reprovado!");
                    Console.WriteLine($"Média inferior:{Mediarecuperacao}");
                }

                Console.ReadKey();
            }
        }
    }
}
