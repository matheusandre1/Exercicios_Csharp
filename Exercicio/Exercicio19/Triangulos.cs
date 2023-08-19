using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    internal class Triangulos
    {
        public int LadoA { get; set; }

        public int LadoB { get; set; }

        public int LadoC { get; set; }

        public void Exibir()
        {
            Console.Write("Insira um valor para o lado A: ");
            LadoA = int.Parse(Console.ReadLine());

            Console.Write("Insira um valor para o lado B: ");
            LadoB = int.Parse(Console.ReadLine());

            Console.Write("Insira um valor para o lado C: ");
            LadoC = int.Parse(Console.ReadLine());

            IdentificarTriangulos();

        }

        public void IdentificarTriangulos()
        {
            if (LadoA < LadoB + LadoC && LadoB < LadoA + LadoC && LadoC < LadoA + LadoB)
            {
                if (LadoA == LadoB || LadoB == LadoC)
                {
                    Console.WriteLine("Esse é um triângulo eqüilátero!");
                }
                else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
                {
                    Console.WriteLine("Esse é um triângulo isósceles!");
                }

                else
                {
                    Console.WriteLine("Esse é um triângulo escaleno!");
                }


            }


            else
            {
                Console.WriteLine("Os dados inseridos não se caracterizam com um triangulo");
            }

        }
    }


}

