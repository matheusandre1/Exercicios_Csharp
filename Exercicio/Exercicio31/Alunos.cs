using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio31
{
    internal class Alunos
    {
        public  int  Quantidade { get; set; }

        public String Matricula { get; set;}

        public double Nota { get; set; }

        public double Media { get; set; }



        public void Exibir()
        {
            Console.Write("Quantidade De alunos: ");
            Quantidade = int.Parse(Console.ReadLine());
            double [] alunos = new double[Quantidade];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Write("Digite a Matricula: ");
                Matricula = Console.ReadLine();
                Console.Write("Digite a Nota: ");
                Nota = int.Parse(Console.ReadLine());
                Media += Nota;
                Console.WriteLine();
            }

            Console.WriteLine($" A Media da turma {string.Format("{0:F1}",(Media/Quantidade))}");
        }
    }
}
