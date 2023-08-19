using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio29
{
    public class Numeros
    {
        public int Numero { get; set; }
        public int Par { get; set; }

        public int Impar { get; set; }

        int ResultadoPar;

        int ResultadoImpar;

        public void Exibir()
        {
            do
            {
                Console.Write("Insira um numero: ");
                Numero = int.Parse(Console.ReadLine());

                if (Numero % 2 == 0)
                {
                    
                    ResultadoPar = ResultadoPar + Numero;
                    Par++;
                }
                else
                {
                    ResultadoImpar = ResultadoImpar + Numero;
                    Impar++;
                }

            } while (Numero >= 0);

            Console.WriteLine($"Quantidade de Números Pares: {Par}");
            Console.WriteLine($" Quantidade de Números Impares: {Impar}");
            Console.WriteLine($"A soma dos Pares: {ResultadoPar}");
            Console.WriteLine($" A soma dos Impares: {ResultadoImpar}");
                

        }
    }
}
