using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Numeros
    {
        public int num1 { get; set; }

        public int num2 { get; set; }

        public int num3 { get; set; }

        public int numerosdescrentes;

        public void Exibir()
        {
            Console.WriteLine("Leitura de numeros Inteiros:");

            List<int> numeros = new List<int>();
            numeros.Add(num1);
            numeros.Add(num2);
            numeros.Add(num3);

            Console.Write("Inserir o Primeiro Numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Inserir o Segundo Numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Inserir o Terceiro Numero: ");
            num3 = int.Parse(Console.ReadLine());

            


            numeros.Sort();
            numeros.Reverse();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            


            Console.WriteLine("Ordem Decrescente");



        }
    }
}
