using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio23
{
    class Opcoes
    {
        public double num1 { get; set; }

        public double num2 { get; set; }

        public double NumeroResultado { get; set; }

        int Opcao { get; set; }


        public void Exibicao()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Inserir o Primeiro Valor: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Inserir o Segundo Valor: ");
                num2 = double.Parse(Console.ReadLine());

                EscolhaDeOperacoes();
                OperacoesMatematicasdosNumeros();
            }
        }

        public void EscolhaDeOperacoes()
        {
            Console.WriteLine("Escolha As operações: ");
            Console.WriteLine("1 - Adição ");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Opção: ");
            Opcao = int.Parse(Console.ReadLine());


        }

        public void OperacoesMatematicasdosNumeros()
        {
            switch (Opcao)
            {
                case 1:
                    NumeroResultado = num1 + num2;
                    Console.WriteLine($"Resultado: {NumeroResultado}");
                    break;
                case 2:
                    NumeroResultado = num1 - num2;
                    Console.WriteLine($"Resultado: {NumeroResultado}");
                    break;
                case 3:
                    NumeroResultado = num1 * num2;
                    Console.WriteLine($"Resultado: {NumeroResultado}");
                    break;
                case 4:
                    NumeroResultado = num1 / num2;
                    Console.WriteLine($"Resultado: {NumeroResultado.ToString("F2",CultureInfo.InvariantCulture)}");
                    break;
                default:
                    Console.WriteLine("Opção Invalida!");
                    Console.Clear();
                    Console.ReadKey();
                    break;
            }

            

        }




    }
}
